namespace WheelApp
{
    partial class Form1
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
            this.buttonStartTurn = new System.Windows.Forms.Button();
            this.labelWinningSector = new System.Windows.Forms.Label();
            this.buttonBetX1 = new System.Windows.Forms.Button();
            this.buttonBetX2 = new System.Windows.Forms.Button();
            this.buttonBetX5 = new System.Windows.Forms.Button();
            this.buttonBetX10 = new System.Windows.Forms.Button();
            this.buttonBetX20 = new System.Windows.Forms.Button();
            this.buttonBetX40 = new System.Windows.Forms.Button();
            this.labelBetX1 = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.labelBetX2 = new System.Windows.Forms.Label();
            this.labelBetX5 = new System.Windows.Forms.Label();
            this.labelBetX10 = new System.Windows.Forms.Label();
            this.labelBetX20 = new System.Windows.Forms.Label();
            this.labelBetX40 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelBalances = new System.Windows.Forms.Label();
            this.labelPrizes = new System.Windows.Forms.Label();
            this.labelBet = new System.Windows.Forms.Label();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxWheel = new System.Windows.Forms.PictureBox();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmount = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNotEnoughBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartTurn
            // 
            this.buttonStartTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.buttonStartTurn.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartTurn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStartTurn.Location = new System.Drawing.Point(700, 460);
            this.buttonStartTurn.Name = "buttonStartTurn";
            this.buttonStartTurn.Size = new System.Drawing.Size(191, 84);
            this.buttonStartTurn.TabIndex = 2;
            this.buttonStartTurn.Text = "Крутить колесо";
            this.buttonStartTurn.UseVisualStyleBackColor = false;
            this.buttonStartTurn.Click += new System.EventHandler(this.TriggerWheelSpin);
            // 
            // labelWinningSector
            // 
            this.labelWinningSector.AutoSize = true;
            this.labelWinningSector.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinningSector.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWinningSector.Location = new System.Drawing.Point(49, 160);
            this.labelWinningSector.MaximumSize = new System.Drawing.Size(160, 0);
            this.labelWinningSector.Name = "labelWinningSector";
            this.labelWinningSector.Size = new System.Drawing.Size(131, 64);
            this.labelWinningSector.TabIndex = 3;
            this.labelWinningSector.Text = "Выиграл сектор х";
            this.labelWinningSector.Visible = false;
            // 
            // buttonBetX1
            // 
            this.buttonBetX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.buttonBetX1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX1.Location = new System.Drawing.Point(294, 460);
            this.buttonBetX1.Name = "buttonBetX1";
            this.buttonBetX1.Size = new System.Drawing.Size(93, 32);
            this.buttonBetX1.TabIndex = 4;
            this.buttonBetX1.Text = "1";
            this.buttonBetX1.UseVisualStyleBackColor = false;
            this.buttonBetX1.Click += new System.EventHandler(this.BetOnSectorX1);
            // 
            // buttonBetX2
            // 
            this.buttonBetX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.buttonBetX2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX2.Location = new System.Drawing.Point(439, 460);
            this.buttonBetX2.Name = "buttonBetX2";
            this.buttonBetX2.Size = new System.Drawing.Size(93, 32);
            this.buttonBetX2.TabIndex = 5;
            this.buttonBetX2.Text = "2";
            this.buttonBetX2.UseVisualStyleBackColor = false;
            this.buttonBetX2.Click += new System.EventHandler(this.BetOnSectorX2);
            // 
            // buttonBetX5
            // 
            this.buttonBetX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.buttonBetX5.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX5.Location = new System.Drawing.Point(570, 460);
            this.buttonBetX5.Name = "buttonBetX5";
            this.buttonBetX5.Size = new System.Drawing.Size(93, 32);
            this.buttonBetX5.TabIndex = 6;
            this.buttonBetX5.Text = "5";
            this.buttonBetX5.UseVisualStyleBackColor = false;
            this.buttonBetX5.Click += new System.EventHandler(this.BetOnSectorX5);
            // 
            // buttonBetX10
            // 
            this.buttonBetX10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.buttonBetX10.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX10.Location = new System.Drawing.Point(294, 512);
            this.buttonBetX10.Name = "buttonBetX10";
            this.buttonBetX10.Size = new System.Drawing.Size(93, 32);
            this.buttonBetX10.TabIndex = 7;
            this.buttonBetX10.Text = "10";
            this.buttonBetX10.UseVisualStyleBackColor = false;
            this.buttonBetX10.Click += new System.EventHandler(this.BetOnSectorX10);
            // 
            // buttonBetX20
            // 
            this.buttonBetX20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.buttonBetX20.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX20.Location = new System.Drawing.Point(439, 512);
            this.buttonBetX20.Name = "buttonBetX20";
            this.buttonBetX20.Size = new System.Drawing.Size(93, 32);
            this.buttonBetX20.TabIndex = 8;
            this.buttonBetX20.Text = "20";
            this.buttonBetX20.UseVisualStyleBackColor = false;
            this.buttonBetX20.Click += new System.EventHandler(this.BetOnSectorX20);
            // 
            // buttonBetX40
            // 
            this.buttonBetX40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.buttonBetX40.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX40.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX40.Location = new System.Drawing.Point(570, 512);
            this.buttonBetX40.Name = "buttonBetX40";
            this.buttonBetX40.Size = new System.Drawing.Size(93, 32);
            this.buttonBetX40.TabIndex = 9;
            this.buttonBetX40.Text = "Д";
            this.buttonBetX40.UseVisualStyleBackColor = false;
            this.buttonBetX40.Click += new System.EventHandler(this.BetOnSectorX40);
            // 
            // labelBetX1
            // 
            this.labelBetX1.AutoSize = true;
            this.labelBetX1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX1.Location = new System.Drawing.Point(700, 101);
            this.labelBetX1.Name = "labelBetX1";
            this.labelBetX1.Size = new System.Drawing.Size(152, 18);
            this.labelBetX1.TabIndex = 10;
            this.labelBetX1.Text = "Сектор: 1 - Ставка: ";
            // 
            // textBoxBet
            // 
            this.textBoxBet.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBet.Location = new System.Drawing.Point(435, 567);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(100, 29);
            this.textBoxBet.TabIndex = 11;
            this.textBoxBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNonNumericKeyPress);
            // 
            // labelBetX2
            // 
            this.labelBetX2.AutoSize = true;
            this.labelBetX2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX2.Location = new System.Drawing.Point(700, 135);
            this.labelBetX2.Name = "labelBetX2";
            this.labelBetX2.Size = new System.Drawing.Size(152, 18);
            this.labelBetX2.TabIndex = 12;
            this.labelBetX2.Text = "Сектор: 2 - Ставка: ";
            // 
            // labelBetX5
            // 
            this.labelBetX5.AutoSize = true;
            this.labelBetX5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX5.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX5.Location = new System.Drawing.Point(700, 171);
            this.labelBetX5.Name = "labelBetX5";
            this.labelBetX5.Size = new System.Drawing.Size(152, 18);
            this.labelBetX5.TabIndex = 13;
            this.labelBetX5.Text = "Сектор: 5 - Ставка: ";
            // 
            // labelBetX10
            // 
            this.labelBetX10.AutoSize = true;
            this.labelBetX10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX10.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX10.Location = new System.Drawing.Point(700, 205);
            this.labelBetX10.Name = "labelBetX10";
            this.labelBetX10.Size = new System.Drawing.Size(161, 18);
            this.labelBetX10.TabIndex = 14;
            this.labelBetX10.Text = "Сектор: 10 - Ставка: ";
            // 
            // labelBetX20
            // 
            this.labelBetX20.AutoSize = true;
            this.labelBetX20.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX20.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX20.Location = new System.Drawing.Point(700, 236);
            this.labelBetX20.Name = "labelBetX20";
            this.labelBetX20.Size = new System.Drawing.Size(161, 18);
            this.labelBetX20.TabIndex = 15;
            this.labelBetX20.Text = "Сектор: 20 - Ставка: ";
            // 
            // labelBetX40
            // 
            this.labelBetX40.AutoSize = true;
            this.labelBetX40.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX40.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX40.Location = new System.Drawing.Point(700, 268);
            this.labelBetX40.Name = "labelBetX40";
            this.labelBetX40.Size = new System.Drawing.Size(161, 18);
            this.labelBetX40.TabIndex = 16;
            this.labelBetX40.Text = "Сектор: 40 - Ставка: ";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBalance.Location = new System.Drawing.Point(49, 328);
            this.labelBalance.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(148, 24);
            this.labelBalance.TabIndex = 17;
            this.labelBalance.Text = "Баланс: 1000";
            // 
            // labelBalances
            // 
            this.labelBalances.Location = new System.Drawing.Point(0, 0);
            this.labelBalances.Name = "labelBalances";
            this.labelBalances.Size = new System.Drawing.Size(100, 23);
            this.labelBalances.TabIndex = 36;
            // 
            // labelPrizes
            // 
            this.labelPrizes.Location = new System.Drawing.Point(0, 0);
            this.labelPrizes.Name = "labelPrizes";
            this.labelPrizes.Size = new System.Drawing.Size(100, 23);
            this.labelPrizes.TabIndex = 35;
            // 
            // labelBet
            // 
            this.labelBet.Location = new System.Drawing.Point(0, 0);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(100, 23);
            this.labelBet.TabIndex = 33;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Image = global::WheelApp.Properties.Resources.white_arrow;
            this.pictureBoxArrow.Location = new System.Drawing.Point(444, 2);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(83, 56);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 1;
            this.pictureBoxArrow.TabStop = false;
            // 
            // pictureBoxWheel
            // 
            this.pictureBoxWheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pictureBoxWheel.ErrorImage = global::WheelApp.Properties.Resources.wheel;
            this.pictureBoxWheel.Image = global::WheelApp.Properties.Resources.wheel1;
            this.pictureBoxWheel.InitialImage = global::WheelApp.Properties.Resources.wheel;
            this.pictureBoxWheel.Location = new System.Drawing.Point(294, 64);
            this.pictureBoxWheel.Name = "pictureBoxWheel";
            this.pictureBoxWheel.Size = new System.Drawing.Size(369, 369);
            this.pictureBoxWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxWheel.TabIndex = 0;
            this.pictureBoxWheel.TabStop = false;
            // 
            // depositTextBox
            // 
            this.depositTextBox.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositTextBox.Location = new System.Drawing.Point(49, 375);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(153, 29);
            this.depositTextBox.TabIndex = 30;
            // 
            // depositAmount
            // 
            this.depositAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.depositAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.depositAmount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.depositAmount.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depositAmount.Location = new System.Drawing.Point(49, 412);
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(154, 32);
            this.depositAmount.TabIndex = 31;
            this.depositAmount.Text = "Пополнить";
            this.depositAmount.UseVisualStyleBackColor = false;
            this.depositAmount.Click += new System.EventHandler(this.depositAmount_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.button2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(49, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 84);
            this.button2.TabIndex = 32;
            this.button2.Text = "Правила";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNotEnoughBalance
            // 
            this.labelNotEnoughBalance.Location = new System.Drawing.Point(0, 0);
            this.labelNotEnoughBalance.Name = "labelNotEnoughBalance";
            this.labelNotEnoughBalance.Size = new System.Drawing.Size(100, 23);
            this.labelNotEnoughBalance.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(937, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.depositAmount);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.labelNotEnoughBalance);
            this.Controls.Add(this.labelPrizes);
            this.Controls.Add(this.labelBalances);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelBetX40);
            this.Controls.Add(this.labelBetX20);
            this.Controls.Add(this.labelBetX10);
            this.Controls.Add(this.labelBetX5);
            this.Controls.Add(this.labelBetX2);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.labelBetX1);
            this.Controls.Add(this.buttonBetX40);
            this.Controls.Add(this.buttonBetX20);
            this.Controls.Add(this.buttonBetX10);
            this.Controls.Add(this.buttonBetX5);
            this.Controls.Add(this.buttonBetX2);
            this.Controls.Add(this.buttonBetX1);
            this.Controls.Add(this.labelWinningSector);
            this.Controls.Add(this.buttonStartTurn);
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.pictureBoxWheel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelNotEnoughBalance;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button depositAmount;

        private System.Windows.Forms.TextBox depositTextBox;

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWheel;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.Button buttonStartTurn;
        private System.Windows.Forms.Label labelWinningSector;
        private System.Windows.Forms.Button buttonBetX1;
        private System.Windows.Forms.Button buttonBetX2;
        private System.Windows.Forms.Button buttonBetX5;
        private System.Windows.Forms.Button buttonBetX10;
        private System.Windows.Forms.Button buttonBetX20;
        private System.Windows.Forms.Button buttonBetX40;
        private System.Windows.Forms.Label labelBetX1;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label labelBetX2;
        private System.Windows.Forms.Label labelBetX5;
        private System.Windows.Forms.Label labelBetX10;
        private System.Windows.Forms.Label labelBetX20;
        private System.Windows.Forms.Label labelBetX40;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelBalances;
        private System.Windows.Forms.Label labelPrizes;
        private System.Windows.Forms.Label labelBet;
    }
}

