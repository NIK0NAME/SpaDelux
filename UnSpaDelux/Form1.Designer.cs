namespace UnSpaDelux
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaToallas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkOcupado = new System.Windows.Forms.CheckBox();
            this.panelDucha = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaToallas
            // 
            this.listaToallas.HideSelection = false;
            this.listaToallas.Location = new System.Drawing.Point(71, 67);
            this.listaToallas.Name = "listaToallas";
            this.listaToallas.Size = new System.Drawing.Size(121, 188);
            this.listaToallas.TabIndex = 0;
            this.listaToallas.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toallas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuarios";
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(143, 13);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(49, 20);
            this.txtUsuarios.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkOcupado
            // 
            this.checkOcupado.AutoSize = true;
            this.checkOcupado.Location = new System.Drawing.Point(71, 291);
            this.checkOcupado.Name = "checkOcupado";
            this.checkOcupado.Size = new System.Drawing.Size(70, 17);
            this.checkOcupado.TabIndex = 6;
            this.checkOcupado.Text = "Ocupado";
            this.checkOcupado.UseVisualStyleBackColor = true;
            // 
            // panelDucha
            // 
            this.panelDucha.BackColor = System.Drawing.Color.Transparent;
            this.panelDucha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDucha.BackgroundImage")));
            this.panelDucha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDucha.Location = new System.Drawing.Point(199, 67);
            this.panelDucha.Name = "panelDucha";
            this.panelDucha.Size = new System.Drawing.Size(48, 41);
            this.panelDucha.TabIndex = 7;
            this.panelDucha.Visible = false;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(199, 262);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Cls";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 321);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.panelDucha);
            this.Controls.Add(this.checkOcupado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaToallas);
            this.Name = "Form1";
            this.Text = "Spa DELUX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaToallas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkOcupado;
        private System.Windows.Forms.Panel panelDucha;
        private System.Windows.Forms.Button btnClean;
    }
}

