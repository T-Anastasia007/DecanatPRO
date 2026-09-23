namespace DecanatPRO
{
    partial class FormAdd
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelSpec, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelGroup, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSpec, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGroup, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.601255F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.601255F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.601255F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.588703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.588703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.601255F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 844);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Rodchenko", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление студента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Rodchenko", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(139, 153);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(398, 77);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФИО";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSpec.Font = new System.Drawing.Font("Rodchenko", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpec.Location = new System.Drawing.Point(139, 307);
            this.labelSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(398, 77);
            this.labelSpec.TabIndex = 2;
            this.labelSpec.Text = "Специальность:";
            this.labelSpec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGroup.Font = new System.Drawing.Font("Rodchenko", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(139, 461);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(398, 77);
            this.labelGroup.TabIndex = 3;
            this.labelGroup.Text = "Группа:";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(139, 234);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(398, 34);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSpec.Location = new System.Drawing.Point(139, 388);
            this.textBoxSpec.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.Size = new System.Drawing.Size(398, 34);
            this.textBoxSpec.TabIndex = 5;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGroup.Location = new System.Drawing.Point(139, 542);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(398, 34);
            this.textBoxGroup.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Font = new System.Drawing.Font("Rodchenko", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(138, 656);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(400, 66);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Font = new System.Drawing.Font("Rodchenko", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(138, 728);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(400, 66);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(678, 844);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Rodchenko", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdd";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSpec;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}