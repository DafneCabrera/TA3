using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA2.entities;
using static System.Windows.Forms.MonthCalendar;

namespace TA2
{

    public partial class Form1 : Form
    {

        private List<Cine> cines = new List<Cine>();

        private void ActualizarDataGrid()
        {
            dtgviewCine.DataSource = null;
            dtgviewCine.DataSource = cines;
        }
        private void LimpiarCampos()
        {
            tboxCodigo.Clear();
            tboxDireccion.Clear();
            tboxArea.Clear();
            tboxGerente.Clear();
            tboxCapacidad.Clear();
            tboxNomCine.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            dtgviewCine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrarCine_Click(object sender, EventArgs e)
        {
            string codigo = tboxCodigo.Text.Trim();

         
            if (cines.Any(c => c.Codigo == codigo))
            {
                MessageBox.Show("El código ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Cine nuevoCine = new Cine(
                codigo,
               
                tboxDireccion.Text.Trim(),
                Convert.ToDouble(tboxArea.Text.Trim()),
                tboxGerente.Text.Trim(),
                Convert.ToInt32(tboxCapacidad.Text.Trim()),
                tboxNomCine.Text.Trim()
            );

            cines.Add(nuevoCine); 
            ActualizarDataGrid();
            LimpiarCampos();
        }

        private void dtgviewCine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarCine_Click(object sender, EventArgs e)
        {
            if (dtgviewCine.SelectedRows.Count > 0)
            {
                string codigo = dtgviewCine.SelectedRows[0].Cells["Codigo"].Value.ToString();
                cines.RemoveAll(c => c.Codigo == codigo);
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un cine para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = tboxNomCine.Text.Trim().ToLower(); 

            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un nombre de cine para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var resultados = cines.Where(c => c.NomCine.ToLower().Contains(criterio)).ToList();

          
            dtgviewCine.DataSource = null;
            dtgviewCine.DataSource = resultados;

            
            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ordenAscendente = false; 
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (ordenAscendente)
            {
                cines = cines.OrderBy(c => c.Gerente).ToList();
            }
            else
            {
                cines = cines.OrderByDescending(c => c.Gerente).ToList(); 
            }

            ordenAscendente = !ordenAscendente; 

            dtgviewCine.DataSource = null;
            dtgviewCine.DataSource = cines;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionaCineClick(object sender, EventArgs e)
        {

        }
    }
    }

