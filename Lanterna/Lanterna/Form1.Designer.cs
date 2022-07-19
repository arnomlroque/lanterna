
namespace Lanterna
{
    partial class FormLanterna
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
            this.components = new System.ComponentModel.Container();
            this.radioButtonLaternaOn = new System.Windows.Forms.RadioButton();
            this.radioButtonLaternaOff = new System.Windows.Forms.RadioButton();
            this.progressBarBateria = new System.Windows.Forms.ProgressBar();
            this.buttonTrocarBateria = new System.Windows.Forms.Button();
            this.timerBateria = new System.Windows.Forms.Timer(this.components);
            this.labelPorcentagemBateria = new System.Windows.Forms.Label();
            this.labelTituloLanterna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonLaternaOn
            // 
            this.radioButtonLaternaOn.AutoSize = true;
            this.radioButtonLaternaOn.Location = new System.Drawing.Point(80, 113);
            this.radioButtonLaternaOn.Name = "radioButtonLaternaOn";
            this.radioButtonLaternaOn.Size = new System.Drawing.Size(39, 17);
            this.radioButtonLaternaOn.TabIndex = 0;
            this.radioButtonLaternaOn.TabStop = true;
            this.radioButtonLaternaOn.Text = "On";
            this.radioButtonLaternaOn.UseVisualStyleBackColor = true;
            this.radioButtonLaternaOn.CheckedChanged += new System.EventHandler(this.radioButtonLaternaOn_CheckedChanged);
            // 
            // radioButtonLaternaOff
            // 
            this.radioButtonLaternaOff.AutoSize = true;
            this.radioButtonLaternaOff.Location = new System.Drawing.Point(80, 149);
            this.radioButtonLaternaOff.Name = "radioButtonLaternaOff";
            this.radioButtonLaternaOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonLaternaOff.TabIndex = 1;
            this.radioButtonLaternaOff.TabStop = true;
            this.radioButtonLaternaOff.Text = "Off";
            this.radioButtonLaternaOff.UseVisualStyleBackColor = true;
            this.radioButtonLaternaOff.CheckedChanged += new System.EventHandler(this.radioButtonLaternaOff_CheckedChanged);
            // 
            // progressBarBateria
            // 
            this.progressBarBateria.Location = new System.Drawing.Point(12, 57);
            this.progressBarBateria.Name = "progressBarBateria";
            this.progressBarBateria.Size = new System.Drawing.Size(179, 23);
            this.progressBarBateria.TabIndex = 2;
            // 
            // buttonTrocarBateria
            // 
            this.buttonTrocarBateria.Location = new System.Drawing.Point(46, 224);
            this.buttonTrocarBateria.Name = "buttonTrocarBateria";
            this.buttonTrocarBateria.Size = new System.Drawing.Size(119, 23);
            this.buttonTrocarBateria.TabIndex = 3;
            this.buttonTrocarBateria.Text = "Trocar Bateria";
            this.buttonTrocarBateria.UseVisualStyleBackColor = true;
            this.buttonTrocarBateria.Click += new System.EventHandler(this.buttonTrocarBateria_Click);
            // 
            // timerBateria
            // 
            this.timerBateria.Interval = 1000;
            this.timerBateria.Tick += new System.EventHandler(this.timerBateria_Tick);
            // 
            // labelPorcentagemBateria
            // 
            this.labelPorcentagemBateria.AutoSize = true;
            this.labelPorcentagemBateria.Location = new System.Drawing.Point(43, 41);
            this.labelPorcentagemBateria.Name = "labelPorcentagemBateria";
            this.labelPorcentagemBateria.Size = new System.Drawing.Size(121, 13);
            this.labelPorcentagemBateria.TabIndex = 4;
            this.labelPorcentagemBateria.Text = "Porcentagem da Bateria";
            // 
            // labelTituloLanterna
            // 
            this.labelTituloLanterna.AutoSize = true;
            this.labelTituloLanterna.Location = new System.Drawing.Point(43, 9);
            this.labelTituloLanterna.Name = "labelTituloLanterna";
            this.labelTituloLanterna.Size = new System.Drawing.Size(113, 13);
            this.labelTituloLanterna.TabIndex = 5;
            this.labelTituloLanterna.Text = "Simulador de Lanterna";
            // 
            // FormLanterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 276);
            this.Controls.Add(this.labelTituloLanterna);
            this.Controls.Add(this.labelPorcentagemBateria);
            this.Controls.Add(this.buttonTrocarBateria);
            this.Controls.Add(this.progressBarBateria);
            this.Controls.Add(this.radioButtonLaternaOff);
            this.Controls.Add(this.radioButtonLaternaOn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLanterna";
            this.Text = "Lanterna";
            this.Load += new System.EventHandler(this.FormLanterna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonLaternaOn;
        private System.Windows.Forms.RadioButton radioButtonLaternaOff;
        private System.Windows.Forms.ProgressBar progressBarBateria;
        private System.Windows.Forms.Button buttonTrocarBateria;
        private System.Windows.Forms.Timer timerBateria;
        private System.Windows.Forms.Label labelPorcentagemBateria;
        private System.Windows.Forms.Label labelTituloLanterna;
    }
}

