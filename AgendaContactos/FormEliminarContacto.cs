using System;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class FormEliminarContacto : Form
    {
        private TextBox txtPhoneSearch;
        private TextBox txtBuscarPorContacto;
        private Label label1;
        private Label label2;
        private Button btnVolver;
        private Button btnDelete;

        public FormEliminarContacto()
        {
            InitializeComponent();
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de eliminar contacto.");
        }

        private void InitializeComponent()
        {
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBuscarPorContacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(337, 150);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(159, 22);
            this.txtPhoneSearch.TabIndex = 0;
            this.txtPhoneSearch.TextChanged += new System.EventHandler(this.txtPhoneSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtBuscarPorContacto
            // 
            this.txtBuscarPorContacto.Location = new System.Drawing.Point(324, 103);
            this.txtBuscarPorContacto.Name = "txtBuscarPorContacto";
            this.txtBuscarPorContacto.Size = new System.Drawing.Size(159, 22);
            this.txtBuscarPorContacto.TabIndex = 2;
            this.txtBuscarPorContacto.TextChanged += new System.EventHandler(this.txtBuscarPorContacto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELIMINAR POR NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ELIMINAR POR TELÉFONO:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(189, 201);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormEliminarContacto
            // 
            this.ClientSize = new System.Drawing.Size(672, 366);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorContacto);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPhoneSearch);
            this.Name = "FormEliminarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtPhoneSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string phone = txtPhoneSearch.Text;
            string contactName = txtBuscarPorContacto.Text;

            if (string.IsNullOrWhiteSpace(phone) && string.IsNullOrWhiteSpace(contactName))
            {
                MessageBox.Show("Por favor, introduce un número de teléfono o un nombre válido.", "Error");
                return;
            }

            var contact = !string.IsNullOrWhiteSpace(phone)
                ? ClasePrograma.Contacts.Find(c => c.Phone == phone)
                : ClasePrograma.Contacts.Find(c => c.Name.Equals(contactName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                ClasePrograma.Contacts.Remove(contact);
                MessageBox.Show("Contacto eliminado correctamente.", "Éxito");
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto con el criterio de búsqueda proporcionado.", "Error");
            }
        }

        private void txtBuscarPorContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
            Application.OpenForms["MainForm"].Show(); // Muestra el formulario principal ya abierto
        }
    }
}
