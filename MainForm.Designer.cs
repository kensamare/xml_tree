
namespace xml_tree
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.URL_Box = new System.Windows.Forms.TextBox();
            this.LoadXml = new System.Windows.Forms.Button();
            this.XML_tree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // URL_Box
            // 
            this.URL_Box.Location = new System.Drawing.Point(13, 13);
            this.URL_Box.Name = "URL_Box";
            this.URL_Box.Size = new System.Drawing.Size(362, 20);
            this.URL_Box.TabIndex = 0;
            this.URL_Box.Text = "Введите URL...";
            this.URL_Box.Enter += new System.EventHandler(this.URL_Box_Enter);
            this.URL_Box.Leave += new System.EventHandler(this.URL_Box_Leave);
            // 
            // LoadXml
            // 
            this.LoadXml.Location = new System.Drawing.Point(394, 9);
            this.LoadXml.Name = "LoadXml";
            this.LoadXml.Size = new System.Drawing.Size(75, 23);
            this.LoadXml.TabIndex = 1;
            this.LoadXml.Text = "Load Xml";
            this.LoadXml.UseVisualStyleBackColor = true;
            this.LoadXml.Click += new System.EventHandler(this.LoadXml_Click);
            // 
            // XML_tree
            // 
            this.XML_tree.Location = new System.Drawing.Point(13, 50);
            this.XML_tree.Name = "XML_tree";
            this.XML_tree.Size = new System.Drawing.Size(456, 369);
            this.XML_tree.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 438);
            this.Controls.Add(this.XML_tree);
            this.Controls.Add(this.LoadXml);
            this.Controls.Add(this.URL_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Xml Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL_Box;
        private System.Windows.Forms.Button LoadXml;
        private System.Windows.Forms.TreeView XML_tree;
    }
}

