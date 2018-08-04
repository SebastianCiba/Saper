namespace Saper1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zegar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.początkującyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniozaawansowanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaawansowanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najlepszeWynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobryPoczątekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zegar
            // 
            resources.ApplyResources(this.zegar, "zegar");
            this.zegar.Name = "zegar";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.początkującyToolStripMenuItem,
            this.średniozaawansowanyToolStripMenuItem,
            this.zaawansowanyToolStripMenuItem,
            this.najlepszeWynikiToolStripMenuItem,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            resources.ApplyResources(this.plikToolStripMenuItem, "plikToolStripMenuItem");
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            resources.ApplyResources(this.nowaGraToolStripMenuItem, "nowaGraToolStripMenuItem");
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // początkującyToolStripMenuItem
            // 
            this.początkującyToolStripMenuItem.Name = "początkującyToolStripMenuItem";
            resources.ApplyResources(this.początkującyToolStripMenuItem, "początkującyToolStripMenuItem");
            this.początkującyToolStripMenuItem.Click += new System.EventHandler(this.początkującyToolStripMenuItem_Click);
            // 
            // średniozaawansowanyToolStripMenuItem
            // 
            this.średniozaawansowanyToolStripMenuItem.Name = "średniozaawansowanyToolStripMenuItem";
            resources.ApplyResources(this.średniozaawansowanyToolStripMenuItem, "średniozaawansowanyToolStripMenuItem");
            this.średniozaawansowanyToolStripMenuItem.Click += new System.EventHandler(this.średniozaawansowanyToolStripMenuItem_Click);
            // 
            // zaawansowanyToolStripMenuItem
            // 
            this.zaawansowanyToolStripMenuItem.Name = "zaawansowanyToolStripMenuItem";
            resources.ApplyResources(this.zaawansowanyToolStripMenuItem, "zaawansowanyToolStripMenuItem");
            // 
            // najlepszeWynikiToolStripMenuItem
            // 
            this.najlepszeWynikiToolStripMenuItem.Name = "najlepszeWynikiToolStripMenuItem";
            resources.ApplyResources(this.najlepszeWynikiToolStripMenuItem, "najlepszeWynikiToolStripMenuItem");
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            resources.ApplyResources(this.koniecToolStripMenuItem, "koniecToolStripMenuItem");
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dobryPoczątekToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            // 
            // dobryPoczątekToolStripMenuItem
            // 
            this.dobryPoczątekToolStripMenuItem.Name = "dobryPoczątekToolStripMenuItem";
            resources.ApplyResources(this.dobryPoczątekToolStripMenuItem, "dobryPoczątekToolStripMenuItem");
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            resources.ApplyResources(this.informacjeToolStripMenuItem, "informacjeToolStripMenuItem");
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.infoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.zegar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label zegar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem początkującyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniozaawansowanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaawansowanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najlepszeWynikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobryPoczątekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
    }
}

