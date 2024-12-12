using System;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class MainForm : Form
    {
        private Button btnAñadir;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
        private Button btnBuscar;

        public MainForm()

        {
            InitializeComponent();
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormBuscarContacto buscarForm = new FormBuscarContacto();
            buscarForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAñadirContacto añadirForm = new FormAñadirContacto();
            añadirForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormActualizarContacto actualizarForm = new FormActualizarContacto();
            actualizarForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormEliminarContacto eliminarForm = new FormEliminarContacto();
            eliminarForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(292, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(225, 47);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR CONTACTO";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(292, 133);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(225, 47);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "AÑADIR CONTACTO";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(292, 206);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(225, 47);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "ACTUALIZAR CONTACTO";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(292, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 47);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR CONTACTO";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(292, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(225, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(822, 466);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnBuscar);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarContacto buscarForm = new FormBuscarContacto();
            buscarForm.ShowDialog();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FormAñadirContacto añadirForm = new FormAñadirContacto();
            añadirForm.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FormActualizarContacto actualizarForm = new FormActualizarContacto();
            actualizarForm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminarContacto eliminarForm = new FormEliminarContacto();
            eliminarForm.ShowDialog();
        }
    }
}
