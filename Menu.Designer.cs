namespace INICIO
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            móduloProyectosToolStripMenuItem = new ToolStripMenuItem();
            proyectoInventarioToolStripMenuItem = new ToolStripMenuItem();
            seguimientoToolStripMenuItem = new ToolStripMenuItem();
            contratosToolStripMenuItem = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            móduloServiciosToolStripMenuItem = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            móduloInventarioToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            móduloFacturaciónToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            móduloAdministraciónToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            aRCHIVOToolStripMenuItem = new ToolStripMenuItem();
            gUARDARToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { móduloProyectosToolStripMenuItem, móduloServiciosToolStripMenuItem, móduloInventarioToolStripMenuItem, móduloFacturaciónToolStripMenuItem, móduloAdministraciónToolStripMenuItem, aRCHIVOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(953, 28);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // móduloProyectosToolStripMenuItem
            // 
            móduloProyectosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proyectoInventarioToolStripMenuItem, seguimientoToolStripMenuItem, contratosToolStripMenuItem, procesosToolStripMenuItem });
            móduloProyectosToolStripMenuItem.Name = "móduloProyectosToolStripMenuItem";
            móduloProyectosToolStripMenuItem.Size = new Size(148, 24);
            móduloProyectosToolStripMenuItem.Text = "Módulo Proyectos";
            // 
            // proyectoInventarioToolStripMenuItem
            // 
            proyectoInventarioToolStripMenuItem.Image = Properties.Resources.INVENTARIO;
            proyectoInventarioToolStripMenuItem.Name = "proyectoInventarioToolStripMenuItem";
            proyectoInventarioToolStripMenuItem.Size = new Size(216, 24);
            proyectoInventarioToolStripMenuItem.Text = "Proyecto Inventario";
            // 
            // seguimientoToolStripMenuItem
            // 
            seguimientoToolStripMenuItem.Image = Properties.Resources.SEGUIMIENTO;
            seguimientoToolStripMenuItem.Name = "seguimientoToolStripMenuItem";
            seguimientoToolStripMenuItem.Size = new Size(216, 24);
            seguimientoToolStripMenuItem.Text = "Seguimiento";
            // 
            // contratosToolStripMenuItem
            // 
            contratosToolStripMenuItem.Image = Properties.Resources.CONTRATO;
            contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            contratosToolStripMenuItem.Size = new Size(216, 24);
            contratosToolStripMenuItem.Text = "Contratos";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.Image = Properties.Resources.PROCESO;
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(216, 24);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // móduloServiciosToolStripMenuItem
            // 
            móduloServiciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serviciosToolStripMenuItem, clientesToolStripMenuItem });
            móduloServiciosToolStripMenuItem.Name = "móduloServiciosToolStripMenuItem";
            móduloServiciosToolStripMenuItem.Size = new Size(141, 24);
            móduloServiciosToolStripMenuItem.Text = "Módulo Servicios";
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.Image = Properties.Resources.SERVICIOS;
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(140, 24);
            serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = Properties.Resources.CLIENTE;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(140, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // móduloInventarioToolStripMenuItem
            // 
            móduloInventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, proveedoresToolStripMenuItem });
            móduloInventarioToolStripMenuItem.Name = "móduloInventarioToolStripMenuItem";
            móduloInventarioToolStripMenuItem.Size = new Size(150, 24);
            móduloInventarioToolStripMenuItem.Text = "Módulo inventario";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Image = Properties.Resources.INVENTARIOOO;
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(165, 24);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Image = Properties.Resources.PROVEEDORES;
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(165, 24);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // móduloFacturaciónToolStripMenuItem
            // 
            móduloFacturaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturasToolStripMenuItem, pagosToolStripMenuItem });
            móduloFacturaciónToolStripMenuItem.Name = "móduloFacturaciónToolStripMenuItem";
            móduloFacturaciónToolStripMenuItem.Size = new Size(160, 24);
            móduloFacturaciónToolStripMenuItem.Text = "Módulo Facturación";
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Image = Properties.Resources.FACTURAS;
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(137, 24);
            facturasToolStripMenuItem.Text = "Facturas";
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.Image = Properties.Resources.PAGOS;
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.Size = new Size(137, 24);
            pagosToolStripMenuItem.Text = "Pagos";
            // 
            // móduloAdministraciónToolStripMenuItem
            // 
            móduloAdministraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, rolesToolStripMenuItem });
            móduloAdministraciónToolStripMenuItem.Name = "móduloAdministraciónToolStripMenuItem";
            móduloAdministraciónToolStripMenuItem.Size = new Size(186, 24);
            móduloAdministraciónToolStripMenuItem.Text = "Módulo Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Image = Properties.Resources.USUARIOS;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(139, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.Image = Properties.Resources.ROLES;
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(139, 24);
            rolesToolStripMenuItem.Text = "Roles";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gUARDARToolStripMenuItem, sALIRToolStripMenuItem });
            aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            aRCHIVOToolStripMenuItem.Size = new Size(75, 24);
            aRCHIVOToolStripMenuItem.Text = "Archivo";
            // 
            // gUARDARToolStripMenuItem
            // 
            gUARDARToolStripMenuItem.Image = Properties.Resources.GUARDAR;
            gUARDARToolStripMenuItem.Name = "gUARDARToolStripMenuItem";
            gUARDARToolStripMenuItem.Size = new Size(153, 24);
            gUARDARToolStripMenuItem.Text = "GUARDAR";
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Image = Properties.Resources.SALIR;
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(153, 24);
            sALIRToolStripMenuItem.Text = "SALIR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 192);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 185);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(402, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 64);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(953, 445);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem móduloProyectosToolStripMenuItem;
        private ToolStripMenuItem proyectoInventarioToolStripMenuItem;
        private ToolStripMenuItem seguimientoToolStripMenuItem;
        private ToolStripMenuItem contratosToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem móduloServiciosToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem móduloInventarioToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem móduloFacturaciónToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem móduloAdministraciónToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private ToolStripMenuItem gUARDARToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}