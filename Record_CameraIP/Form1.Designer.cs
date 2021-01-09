namespace Record_CameraIP
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
               this.txtIP_Address = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.btnOpen = new System.Windows.Forms.Button();
               this.btnRecord = new System.Windows.Forms.Button();
               this.btnStop = new System.Windows.Forms.Button();
               this.btnStart = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.display = new System.Windows.Forms.PictureBox();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
               this.SuspendLayout();
               // 
               // txtIP_Address
               // 
               this.txtIP_Address.Location = new System.Drawing.Point(76, 362);
               this.txtIP_Address.Name = "txtIP_Address";
               this.txtIP_Address.Size = new System.Drawing.Size(502, 20);
               this.txtIP_Address.TabIndex = 1;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 365);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(58, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "IP Address";
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.btnOpen);
               this.groupBox1.Controls.Add(this.btnRecord);
               this.groupBox1.Controls.Add(this.btnStop);
               this.groupBox1.Controls.Add(this.btnStart);
               this.groupBox1.Location = new System.Drawing.Point(12, 417);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(563, 70);
               this.groupBox1.TabIndex = 3;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Controls";
               // 
               // btnOpen
               // 
               this.btnOpen.Location = new System.Drawing.Point(482, 31);
               this.btnOpen.Name = "btnOpen";
               this.btnOpen.Size = new System.Drawing.Size(75, 23);
               this.btnOpen.TabIndex = 10;
               this.btnOpen.Text = "Open";
               this.btnOpen.UseVisualStyleBackColor = true;
               // 
               // btnRecord
               // 
               this.btnRecord.Location = new System.Drawing.Point(326, 31);
               this.btnRecord.Name = "btnRecord";
               this.btnRecord.Size = new System.Drawing.Size(75, 23);
               this.btnRecord.TabIndex = 9;
               this.btnRecord.Text = "Record";
               this.btnRecord.UseVisualStyleBackColor = true;
               // 
               // btnStop
               // 
               this.btnStop.Location = new System.Drawing.Point(161, 31);
               this.btnStop.Name = "btnStop";
               this.btnStop.Size = new System.Drawing.Size(75, 23);
               this.btnStop.TabIndex = 8;
               this.btnStop.Text = "Stop";
               this.btnStop.UseVisualStyleBackColor = true;
               // 
               // btnStart
               // 
               this.btnStart.Location = new System.Drawing.Point(6, 31);
               this.btnStart.Name = "btnStart";
               this.btnStart.Size = new System.Drawing.Size(75, 23);
               this.btnStart.TabIndex = 7;
               this.btnStart.Text = "Start";
               this.btnStart.UseVisualStyleBackColor = true;
               this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(271, 9);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(41, 13);
               this.label2.TabIndex = 4;
               this.label2.Text = "Display";
               // 
               // display
               // 
               this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.display.Location = new System.Drawing.Point(15, 34);
               this.display.Name = "display";
               this.display.Size = new System.Drawing.Size(566, 310);
               this.display.TabIndex = 5;
               this.display.TabStop = false;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(593, 526);
               this.Controls.Add(this.display);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.txtIP_Address);
               this.Name = "Form1";
               this.Text = "Form1";
               this.groupBox1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.TextBox txtIP_Address;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.Button btnOpen;
          private System.Windows.Forms.Button btnRecord;
          private System.Windows.Forms.Button btnStop;
          private System.Windows.Forms.Button btnStart;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.PictureBox display;
     }
}

