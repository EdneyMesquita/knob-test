namespace KnobTest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.knobControl = new KnobControl.KnobControl();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // knobControl
            // 
            this.knobControl.EndAngle = 405F;
            this.knobControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobControl.knobBackColor = System.Drawing.Color.White;
            this.knobControl.KnobPointerStyle = KnobControl.KnobControl.knobPointerStyle.circle;
            this.knobControl.LargeChange = 5;
            this.knobControl.Location = new System.Drawing.Point(296, 187);
            this.knobControl.Maximum = 100;
            this.knobControl.Minimum = 0;
            this.knobControl.Name = "knobControl";
            this.knobControl.PointerColor = System.Drawing.Color.SlateBlue;
            this.knobControl.ScaleColor = System.Drawing.Color.Black;
            this.knobControl.ScaleDivisions = 11;
            this.knobControl.ScaleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.knobControl.ScaleSubDivisions = 4;
            this.knobControl.ShowLargeScale = true;
            this.knobControl.ShowSmallScale = false;
            this.knobControl.Size = new System.Drawing.Size(207, 207);
            this.knobControl.SmallChange = 1;
            this.knobControl.StartAngle = 135F;
            this.knobControl.TabIndex = 0;
            this.knobControl.Value = 0;
            this.knobControl.ValueChanged += new KnobControl.ValueChangedEventHandler(this.knobControl_ValueChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblValor.Location = new System.Drawing.Point(336, 117);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(109, 31);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(172, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quanto a Layzan deve me pagar por este exemplo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.knobControl);
            this.Name = "Form1";
            this.Text = "Testando o Knob Control da Layzan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnobControl.KnobControl knobControl;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label1;
    }
}

