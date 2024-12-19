namespace TicTacToe
{
    partial class TicTacToe_form
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
            this.Canvas_pbox = new System.Windows.Forms.PictureBox();
            this.TargetIP_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect_bt = new System.Windows.Forms.Button();
            this.CreateServer_bt = new System.Windows.Forms.Button();
            this.HumanEnemy_rbt = new System.Windows.Forms.RadioButton();
            this.Bot_enemy_rbt = new System.Windows.Forms.RadioButton();
            this.ChooseEnemy_gbox = new System.Windows.Forms.GroupBox();
            this.ChooseFigure_gbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X_choice_rbt = new System.Windows.Forms.RadioButton();
            this.O_choice_rbt = new System.Windows.Forms.RadioButton();
            this.Close_bt = new System.Windows.Forms.Button();
            this.StartGame_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_pbox)).BeginInit();
            this.ChooseEnemy_gbox.SuspendLayout();
            this.ChooseFigure_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas_pbox
            // 
            this.Canvas_pbox.Location = new System.Drawing.Point(13, 13);
            this.Canvas_pbox.Name = "Canvas_pbox";
            this.Canvas_pbox.Size = new System.Drawing.Size(500, 500);
            this.Canvas_pbox.TabIndex = 0;
            this.Canvas_pbox.TabStop = false;
            this.Canvas_pbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_pbox_Click);
            // 
            // TargetIP_tb
            // 
            this.TargetIP_tb.Location = new System.Drawing.Point(532, 56);
            this.TargetIP_tb.Name = "TargetIP_tb";
            this.TargetIP_tb.Size = new System.Drawing.Size(198, 20);
            this.TargetIP_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(529, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Подключиться к игроку (IP)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите соперника";
            // 
            // Connect_bt
            // 
            this.Connect_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect_bt.Location = new System.Drawing.Point(532, 82);
            this.Connect_bt.Name = "Connect_bt";
            this.Connect_bt.Size = new System.Drawing.Size(198, 28);
            this.Connect_bt.TabIndex = 4;
            this.Connect_bt.Text = "Подключиться";
            this.Connect_bt.UseVisualStyleBackColor = true;
            // 
            // CreateServer_bt
            // 
            this.CreateServer_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateServer_bt.Location = new System.Drawing.Point(532, 116);
            this.CreateServer_bt.Name = "CreateServer_bt";
            this.CreateServer_bt.Size = new System.Drawing.Size(198, 28);
            this.CreateServer_bt.TabIndex = 5;
            this.CreateServer_bt.Text = "Создать сервер";
            this.CreateServer_bt.UseVisualStyleBackColor = true;
            // 
            // HumanEnemy_rbt
            // 
            this.HumanEnemy_rbt.AutoSize = true;
            this.HumanEnemy_rbt.Location = new System.Drawing.Point(28, 48);
            this.HumanEnemy_rbt.Name = "HumanEnemy_rbt";
            this.HumanEnemy_rbt.Size = new System.Drawing.Size(56, 17);
            this.HumanEnemy_rbt.TabIndex = 6;
            this.HumanEnemy_rbt.TabStop = true;
            this.HumanEnemy_rbt.Text = "Игрок";
            this.HumanEnemy_rbt.UseVisualStyleBackColor = true;
            // 
            // Bot_enemy_rbt
            // 
            this.Bot_enemy_rbt.AutoSize = true;
            this.Bot_enemy_rbt.Checked = true;
            this.Bot_enemy_rbt.Location = new System.Drawing.Point(136, 48);
            this.Bot_enemy_rbt.Name = "Bot_enemy_rbt";
            this.Bot_enemy_rbt.Size = new System.Drawing.Size(43, 17);
            this.Bot_enemy_rbt.TabIndex = 7;
            this.Bot_enemy_rbt.TabStop = true;
            this.Bot_enemy_rbt.Text = "Бот";
            this.Bot_enemy_rbt.UseVisualStyleBackColor = true;
            // 
            // ChooseEnemy_gbox
            // 
            this.ChooseEnemy_gbox.Controls.Add(this.label2);
            this.ChooseEnemy_gbox.Controls.Add(this.HumanEnemy_rbt);
            this.ChooseEnemy_gbox.Controls.Add(this.Bot_enemy_rbt);
            this.ChooseEnemy_gbox.Location = new System.Drawing.Point(530, 151);
            this.ChooseEnemy_gbox.Name = "ChooseEnemy_gbox";
            this.ChooseEnemy_gbox.Size = new System.Drawing.Size(200, 100);
            this.ChooseEnemy_gbox.TabIndex = 9;
            this.ChooseEnemy_gbox.TabStop = false;
            // 
            // ChooseFigure_gbox
            // 
            this.ChooseFigure_gbox.Controls.Add(this.label3);
            this.ChooseFigure_gbox.Controls.Add(this.X_choice_rbt);
            this.ChooseFigure_gbox.Controls.Add(this.O_choice_rbt);
            this.ChooseFigure_gbox.Location = new System.Drawing.Point(532, 257);
            this.ChooseFigure_gbox.Name = "ChooseFigure_gbox";
            this.ChooseFigure_gbox.Size = new System.Drawing.Size(200, 100);
            this.ChooseFigure_gbox.TabIndex = 10;
            this.ChooseFigure_gbox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Крестик или нолик?";
            // 
            // X_choice_rbt
            // 
            this.X_choice_rbt.AutoSize = true;
            this.X_choice_rbt.Checked = true;
            this.X_choice_rbt.Location = new System.Drawing.Point(28, 48);
            this.X_choice_rbt.Name = "X_choice_rbt";
            this.X_choice_rbt.Size = new System.Drawing.Size(67, 17);
            this.X_choice_rbt.TabIndex = 6;
            this.X_choice_rbt.TabStop = true;
            this.X_choice_rbt.Text = "Крестик";
            this.X_choice_rbt.UseVisualStyleBackColor = true;
            // 
            // O_choice_rbt
            // 
            this.O_choice_rbt.AutoSize = true;
            this.O_choice_rbt.Location = new System.Drawing.Point(116, 48);
            this.O_choice_rbt.Name = "O_choice_rbt";
            this.O_choice_rbt.Size = new System.Drawing.Size(57, 17);
            this.O_choice_rbt.TabIndex = 7;
            this.O_choice_rbt.TabStop = true;
            this.O_choice_rbt.Text = "Нолик";
            this.O_choice_rbt.UseVisualStyleBackColor = true;
            // 
            // Close_bt
            // 
            this.Close_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_bt.Location = new System.Drawing.Point(530, 485);
            this.Close_bt.Name = "Close_bt";
            this.Close_bt.Size = new System.Drawing.Size(198, 28);
            this.Close_bt.TabIndex = 11;
            this.Close_bt.Text = "Выход";
            this.Close_bt.UseVisualStyleBackColor = true;
            this.Close_bt.Click += new System.EventHandler(this.Close_bt_Click);
            // 
            // StartGame_bt
            // 
            this.StartGame_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame_bt.Location = new System.Drawing.Point(530, 451);
            this.StartGame_bt.Name = "StartGame_bt";
            this.StartGame_bt.Size = new System.Drawing.Size(198, 28);
            this.StartGame_bt.TabIndex = 12;
            this.StartGame_bt.Text = "Начать игру";
            this.StartGame_bt.UseVisualStyleBackColor = true;
            this.StartGame_bt.Click += new System.EventHandler(this.StartGame_bt_Click);
            // 
            // TicTacToe_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 527);
            this.Controls.Add(this.StartGame_bt);
            this.Controls.Add(this.Close_bt);
            this.Controls.Add(this.ChooseFigure_gbox);
            this.Controls.Add(this.ChooseEnemy_gbox);
            this.Controls.Add(this.CreateServer_bt);
            this.Controls.Add(this.Connect_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TargetIP_tb);
            this.Controls.Add(this.Canvas_pbox);
            this.Name = "TicTacToe_form";
            this.Text = "Крестики-Нолики";
            this.Load += new System.EventHandler(this.TicTacToe_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_pbox)).EndInit();
            this.ChooseEnemy_gbox.ResumeLayout(false);
            this.ChooseEnemy_gbox.PerformLayout();
            this.ChooseFigure_gbox.ResumeLayout(false);
            this.ChooseFigure_gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas_pbox;
        private System.Windows.Forms.TextBox TargetIP_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Connect_bt;
        private System.Windows.Forms.Button CreateServer_bt;
        private System.Windows.Forms.RadioButton HumanEnemy_rbt;
        private System.Windows.Forms.RadioButton Bot_enemy_rbt;
        private System.Windows.Forms.GroupBox ChooseEnemy_gbox;
        private System.Windows.Forms.GroupBox ChooseFigure_gbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton X_choice_rbt;
        private System.Windows.Forms.RadioButton O_choice_rbt;
        private System.Windows.Forms.Button Close_bt;
        private System.Windows.Forms.Button StartGame_bt;
    }
}

