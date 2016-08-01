namespace OS_MemoryBF_FF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox_Algorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_MemorySize = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtBox_ProcessSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.txtBox_ProcessID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBox_DisplayMemory = new System.Windows.Forms.TextBox();
            this.btn_DisplayMemory = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.GroupBox();
            this.txtBox_State = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.btn_Create);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBox_Algorithm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_MemorySize);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Create.Location = new System.Drawing.Point(421, 19);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(90, 46);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "CREATE";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Algorithm";
            // 
            // cmbBox_Algorithm
            // 
            this.cmbBox_Algorithm.FormattingEnabled = true;
            this.cmbBox_Algorithm.Items.AddRange(new object[] {
            "Best Fit",
            "First Fit"});
            this.cmbBox_Algorithm.Location = new System.Drawing.Point(158, 45);
            this.cmbBox_Algorithm.Name = "cmbBox_Algorithm";
            this.cmbBox_Algorithm.Size = new System.Drawing.Size(137, 21);
            this.cmbBox_Algorithm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Memory Size";
            // 
            // txtBox_MemorySize
            // 
            this.txtBox_MemorySize.Location = new System.Drawing.Point(158, 19);
            this.txtBox_MemorySize.Name = "txtBox_MemorySize";
            this.txtBox_MemorySize.Size = new System.Drawing.Size(137, 20);
            this.txtBox_MemorySize.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.txtBox_ProcessSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allocation";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(33, 80);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(64, 39);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtBox_ProcessSize
            // 
            this.txtBox_ProcessSize.Location = new System.Drawing.Point(33, 44);
            this.txtBox_ProcessSize.Name = "txtBox_ProcessSize";
            this.txtBox_ProcessSize.Size = new System.Drawing.Size(64, 20);
            this.txtBox_ProcessSize.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Process Size";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_Remove);
            this.groupBox3.Controls.Add(this.txtBox_ProcessID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(433, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DeAllocation";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(33, 80);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(65, 39);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // txtBox_ProcessID
            // 
            this.txtBox_ProcessID.Location = new System.Drawing.Point(33, 44);
            this.txtBox_ProcessID.Name = "txtBox_ProcessID";
            this.txtBox_ProcessID.Size = new System.Drawing.Size(65, 20);
            this.txtBox_ProcessID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Process ID";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.txtBox_DisplayMemory);
            this.groupBox4.Controls.Add(this.btn_DisplayMemory);
            this.groupBox4.Location = new System.Drawing.Point(156, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 206);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Memory Layout";
            // 
            // txtBox_DisplayMemory
            // 
            this.txtBox_DisplayMemory.Location = new System.Drawing.Point(6, 50);
            this.txtBox_DisplayMemory.Multiline = true;
            this.txtBox_DisplayMemory.Name = "txtBox_DisplayMemory";
            this.txtBox_DisplayMemory.Size = new System.Drawing.Size(248, 150);
            this.txtBox_DisplayMemory.TabIndex = 1;
            // 
            // btn_DisplayMemory
            // 
            this.btn_DisplayMemory.Location = new System.Drawing.Point(89, 22);
            this.btn_DisplayMemory.Name = "btn_DisplayMemory";
            this.btn_DisplayMemory.Size = new System.Drawing.Size(86, 25);
            this.btn_DisplayMemory.TabIndex = 0;
            this.btn_DisplayMemory.Text = "DisplayMemory";
            this.btn_DisplayMemory.UseVisualStyleBackColor = true;
            this.btn_DisplayMemory.Click += new System.EventHandler(this.btn_DisplayMemory_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Info.Controls.Add(this.txtBox_State);
            this.Info.Controls.Add(this.State);
            this.Info.Location = new System.Drawing.Point(12, 337);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(548, 50);
            this.Info.TabIndex = 4;
            this.Info.TabStop = false;
            this.Info.Text = "Info";
            // 
            // txtBox_State
            // 
            this.txtBox_State.Location = new System.Drawing.Point(123, 19);
            this.txtBox_State.Name = "txtBox_State";
            this.txtBox_State.Size = new System.Drawing.Size(318, 20);
            this.txtBox_State.TabIndex = 1;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(62, 22);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(32, 13);
            this.State.TabIndex = 0;
            this.State.Text = "State";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 399);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dynamic Memory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox_Algorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_MemorySize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtBox_ProcessSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox txtBox_ProcessID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBox_DisplayMemory;
        private System.Windows.Forms.Button btn_DisplayMemory;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.TextBox txtBox_State;
        private System.Windows.Forms.Label State;
    }
}

