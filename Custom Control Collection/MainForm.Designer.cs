namespace CustomControlCollection
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMainContent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlButtonsContent = new System.Windows.Forms.TabControl();
            this.tabPageHidetextContent = new System.Windows.Forms.TabPage();
            this.tabPageRoundedContent = new System.Windows.Forms.TabPage();
            this.tabPageColoredContent = new System.Windows.Forms.TabPage();
            this.tabPageToggleContent = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlRichTextBoxesContent = new System.Windows.Forms.TabControl();
            this.tabPagePlaceholderContent = new System.Windows.Forms.TabPage();
            this.tabPageResizableContent = new System.Windows.Forms.TabPage();
            this.tabPageContent = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.hidetextButtonProva = new CustomControlCollection.Controls.Buttons.HidetextButton();
            this.roundedButtonProva = new CustomControlCollection.Controls.Buttons.RoundedButton();
            this.coloredButtonProva = new CustomControlCollection.Controls.Buttons.ColoredButton();
            this.toggleButtonProva = new CustomControlCollection.Controls.Buttons.ToggleButton();
            this.placeholderRichTextBoxProva = new CustomControlCollection.Controls.RichTextBoxes.PlaceholderRichTextBox();
            this.resizableRichTextBoxProva = new CustomControlCollection.Controls.RichTextBoxes.ResizableRichTextBox();
            this.coloredProgressBar1 = new CustomControlCollection.Controls.ColoredProgressBar();
            this.resizedLabelProva = new CustomControlCollection.Controls.ResizedLabel();
            this.tabControlMainContent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlButtonsContent.SuspendLayout();
            this.tabPageHidetextContent.SuspendLayout();
            this.tabPageRoundedContent.SuspendLayout();
            this.tabPageColoredContent.SuspendLayout();
            this.tabPageToggleContent.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlRichTextBoxesContent.SuspendLayout();
            this.tabPagePlaceholderContent.SuspendLayout();
            this.tabPageResizableContent.SuspendLayout();
            this.tabPageContent.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainContent
            // 
            this.tabControlMainContent.Controls.Add(this.tabPage1);
            this.tabControlMainContent.Controls.Add(this.tabPage2);
            this.tabControlMainContent.Controls.Add(this.tabPageContent);
            this.tabControlMainContent.Controls.Add(this.tabPage5);
            this.tabControlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainContent.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainContent.Name = "tabControlMainContent";
            this.tabControlMainContent.SelectedIndex = 0;
            this.tabControlMainContent.Size = new System.Drawing.Size(671, 447);
            this.tabControlMainContent.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControlButtonsContent);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buttons";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlButtonsContent
            // 
            this.tabControlButtonsContent.Controls.Add(this.tabPageHidetextContent);
            this.tabControlButtonsContent.Controls.Add(this.tabPageRoundedContent);
            this.tabControlButtonsContent.Controls.Add(this.tabPageColoredContent);
            this.tabControlButtonsContent.Controls.Add(this.tabPageToggleContent);
            this.tabControlButtonsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlButtonsContent.Location = new System.Drawing.Point(3, 3);
            this.tabControlButtonsContent.Name = "tabControlButtonsContent";
            this.tabControlButtonsContent.SelectedIndex = 0;
            this.tabControlButtonsContent.Size = new System.Drawing.Size(657, 408);
            this.tabControlButtonsContent.TabIndex = 0;
            // 
            // tabPageHidetextContent
            // 
            this.tabPageHidetextContent.Controls.Add(this.hidetextButtonProva);
            this.tabPageHidetextContent.Location = new System.Drawing.Point(4, 29);
            this.tabPageHidetextContent.Name = "tabPageHidetextContent";
            this.tabPageHidetextContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHidetextContent.Size = new System.Drawing.Size(649, 375);
            this.tabPageHidetextContent.TabIndex = 0;
            this.tabPageHidetextContent.Text = "Hidetext";
            this.tabPageHidetextContent.UseVisualStyleBackColor = true;
            // 
            // tabPageRoundedContent
            // 
            this.tabPageRoundedContent.Controls.Add(this.roundedButtonProva);
            this.tabPageRoundedContent.Location = new System.Drawing.Point(4, 29);
            this.tabPageRoundedContent.Name = "tabPageRoundedContent";
            this.tabPageRoundedContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoundedContent.Size = new System.Drawing.Size(649, 375);
            this.tabPageRoundedContent.TabIndex = 1;
            this.tabPageRoundedContent.Text = "Rounded";
            this.tabPageRoundedContent.UseVisualStyleBackColor = true;
            // 
            // tabPageColoredContent
            // 
            this.tabPageColoredContent.Controls.Add(this.coloredButtonProva);
            this.tabPageColoredContent.Location = new System.Drawing.Point(4, 29);
            this.tabPageColoredContent.Name = "tabPageColoredContent";
            this.tabPageColoredContent.Size = new System.Drawing.Size(649, 375);
            this.tabPageColoredContent.TabIndex = 2;
            this.tabPageColoredContent.Text = "Colored";
            this.tabPageColoredContent.UseVisualStyleBackColor = true;
            // 
            // tabPageToggleContent
            // 
            this.tabPageToggleContent.Controls.Add(this.toggleButtonProva);
            this.tabPageToggleContent.Location = new System.Drawing.Point(4, 29);
            this.tabPageToggleContent.Name = "tabPageToggleContent";
            this.tabPageToggleContent.Size = new System.Drawing.Size(649, 375);
            this.tabPageToggleContent.TabIndex = 3;
            this.tabPageToggleContent.Text = "Toggle";
            this.tabPageToggleContent.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlRichTextBoxesContent);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RichTextBoxes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlRichTextBoxesContent
            // 
            this.tabControlRichTextBoxesContent.Controls.Add(this.tabPagePlaceholderContent);
            this.tabControlRichTextBoxesContent.Controls.Add(this.tabPageResizableContent);
            this.tabControlRichTextBoxesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRichTextBoxesContent.Location = new System.Drawing.Point(3, 3);
            this.tabControlRichTextBoxesContent.Name = "tabControlRichTextBoxesContent";
            this.tabControlRichTextBoxesContent.SelectedIndex = 0;
            this.tabControlRichTextBoxesContent.Size = new System.Drawing.Size(657, 415);
            this.tabControlRichTextBoxesContent.TabIndex = 0;
            // 
            // tabPagePlaceholderContent
            // 
            this.tabPagePlaceholderContent.Controls.Add(this.placeholderRichTextBoxProva);
            this.tabPagePlaceholderContent.Location = new System.Drawing.Point(4, 29);
            this.tabPagePlaceholderContent.Name = "tabPagePlaceholderContent";
            this.tabPagePlaceholderContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaceholderContent.Size = new System.Drawing.Size(649, 382);
            this.tabPagePlaceholderContent.TabIndex = 0;
            this.tabPagePlaceholderContent.Text = "Placeholder";
            this.tabPagePlaceholderContent.UseVisualStyleBackColor = true;
            // 
            // tabPageResizableContent
            // 
            this.tabPageResizableContent.Controls.Add(this.resizableRichTextBoxProva);
            this.tabPageResizableContent.Location = new System.Drawing.Point(4, 29);
            this.tabPageResizableContent.Name = "tabPageResizableContent";
            this.tabPageResizableContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResizableContent.Size = new System.Drawing.Size(649, 382);
            this.tabPageResizableContent.TabIndex = 1;
            this.tabPageResizableContent.Text = "Resizable";
            this.tabPageResizableContent.UseVisualStyleBackColor = true;
            // 
            // tabPageContent
            // 
            this.tabPageContent.Controls.Add(this.coloredProgressBar1);
            this.tabPageContent.Location = new System.Drawing.Point(4, 29);
            this.tabPageContent.Name = "tabPageContent";
            this.tabPageContent.Size = new System.Drawing.Size(663, 414);
            this.tabPageContent.TabIndex = 2;
            this.tabPageContent.Text = "ProgressBar";
            this.tabPageContent.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.resizedLabelProva);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(663, 414);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Label";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // hidetextButtonProva
            // 
            this.hidetextButtonProva.Location = new System.Drawing.Point(136, 110);
            this.hidetextButtonProva.Name = "hidetextButtonProva";
            this.hidetextButtonProva.Size = new System.Drawing.Size(154, 54);
            this.hidetextButtonProva.TabIndex = 0;
            this.hidetextButtonProva.Text = "hidetextButtonProva";
            this.hidetextButtonProva.TextVisible = true;
            this.hidetextButtonProva.UseVisualStyleBackColor = true;
            this.hidetextButtonProva.Click += new System.EventHandler(this.hidetextButtonProva_Click);
            // 
            // roundedButtonProva
            // 
            this.roundedButtonProva.BackColor = System.Drawing.Color.LightGray;
            this.roundedButtonProva.FlatAppearance.BorderSize = 0;
            this.roundedButtonProva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonProva.Location = new System.Drawing.Point(247, 121);
            this.roundedButtonProva.Name = "roundedButtonProva";
            this.roundedButtonProva.Size = new System.Drawing.Size(103, 96);
            this.roundedButtonProva.TabIndex = 0;
            this.roundedButtonProva.Text = "roundedButtonProva";
            this.roundedButtonProva.UseVisualStyleBackColor = false;
            // 
            // coloredButtonProva
            // 
            this.coloredButtonProva.BackColor = System.Drawing.SystemColors.ControlLight;
            this.coloredButtonProva.ClickedColor = System.Drawing.SystemColors.ActiveCaption;
            this.coloredButtonProva.Location = new System.Drawing.Point(206, 112);
            this.coloredButtonProva.Name = "coloredButtonProva";
            this.coloredButtonProva.Size = new System.Drawing.Size(148, 75);
            this.coloredButtonProva.TabIndex = 0;
            this.coloredButtonProva.Text = "coloredButton1";
            this.coloredButtonProva.UseVisualStyleBackColor = false;
            // 
            // toggleButtonProva
            // 
            this.toggleButtonProva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toggleButtonProva.Location = new System.Drawing.Point(234, 136);
            this.toggleButtonProva.Name = "toggleButtonProva";
            this.toggleButtonProva.OffColor = System.Drawing.Color.Red;
            this.toggleButtonProva.OnColor = System.Drawing.Color.DodgerBlue;
            this.toggleButtonProva.Size = new System.Drawing.Size(89, 41);
            this.toggleButtonProva.TabIndex = 0;
            this.toggleButtonProva.ToggleColor = System.Drawing.Color.White;
            this.toggleButtonProva.ToggleState = false;
            // 
            // placeholderRichTextBoxProva
            // 
            this.placeholderRichTextBoxProva.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderRichTextBoxProva.Location = new System.Drawing.Point(6, 136);
            this.placeholderRichTextBoxProva.Name = "placeholderRichTextBoxProva";
            this.placeholderRichTextBoxProva.PlaceholderText = "Scrivi qualcosa...";
            this.placeholderRichTextBoxProva.PlaceholerFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderRichTextBoxProva.Size = new System.Drawing.Size(637, 37);
            this.placeholderRichTextBoxProva.TabIndex = 0;
            this.placeholderRichTextBoxProva.Text = "";
            // 
            // resizableRichTextBoxProva
            // 
            this.resizableRichTextBoxProva.CharsPerRow = 50;
            this.resizableRichTextBoxProva.Location = new System.Drawing.Point(6, 29);
            this.resizableRichTextBoxProva.MaxRows = 10;
            this.resizableRichTextBoxProva.Name = "resizableRichTextBoxProva";
            this.resizableRichTextBoxProva.Size = new System.Drawing.Size(637, 141);
            this.resizableRichTextBoxProva.TabIndex = 0;
            this.resizableRichTextBoxProva.Text = "";
            // 
            // coloredProgressBar1
            // 
            this.coloredProgressBar1.Location = new System.Drawing.Point(8, 153);
            this.coloredProgressBar1.Name = "coloredProgressBar1";
            this.coloredProgressBar1.ProgressColor = System.Drawing.Color.Khaki;
            this.coloredProgressBar1.ShowPercentageText = true;
            this.coloredProgressBar1.Size = new System.Drawing.Size(647, 42);
            this.coloredProgressBar1.TabIndex = 0;
            this.coloredProgressBar1.Value = 75;
            // 
            // resizedLabelProva
            // 
            this.resizedLabelProva.AutoSize = true;
            this.resizedLabelProva.Location = new System.Drawing.Point(6, 130);
            this.resizedLabelProva.Name = "resizedLabelProva";
            this.resizedLabelProva.Size = new System.Drawing.Size(592, 20);
            this.resizedLabelProva.TabIndex = 0;
            this.resizedLabelProva.Text = "pfijewfegrtghrhpjtoiirthgnrfeogjporkprgjrepfrjotgthrtyhttty4eygegprejgiogjigijopg" +
    "joritg";
            this.resizedLabelProva.Click += new System.EventHandler(this.resizedLabelProva_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 447);
            this.Controls.Add(this.tabControlMainContent);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Control Collection";
            this.tabControlMainContent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControlButtonsContent.ResumeLayout(false);
            this.tabPageHidetextContent.ResumeLayout(false);
            this.tabPageRoundedContent.ResumeLayout(false);
            this.tabPageColoredContent.ResumeLayout(false);
            this.tabPageToggleContent.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControlRichTextBoxesContent.ResumeLayout(false);
            this.tabPagePlaceholderContent.ResumeLayout(false);
            this.tabPageResizableContent.ResumeLayout(false);
            this.tabPageContent.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainContent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlButtonsContent;
        private System.Windows.Forms.TabPage tabPageHidetextContent;
        private System.Windows.Forms.TabPage tabPageRoundedContent;
        private System.Windows.Forms.TabPage tabPageColoredContent;
        private System.Windows.Forms.TabPage tabPageToggleContent;
        private System.Windows.Forms.TabControl tabControlRichTextBoxesContent;
        private System.Windows.Forms.TabPage tabPagePlaceholderContent;
        private System.Windows.Forms.TabPage tabPageResizableContent;
        private System.Windows.Forms.TabPage tabPageContent;
        private System.Windows.Forms.TabPage tabPage5;
        private Controls.Buttons.HidetextButton hidetextButtonProva;
        private Controls.Buttons.RoundedButton roundedButtonProva;
        private Controls.Buttons.ColoredButton coloredButtonProva;
        private Controls.Buttons.ToggleButton toggleButtonProva;
        private Controls.RichTextBoxes.PlaceholderRichTextBox placeholderRichTextBoxProva;
        private Controls.RichTextBoxes.ResizableRichTextBox resizableRichTextBoxProva;
        private Controls.ColoredProgressBar coloredProgressBar1;
        private Controls.ResizedLabel resizedLabelProva;
    }
}

