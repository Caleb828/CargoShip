
namespace CargoShip2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.track_motorCycles = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.track_trainCars = new System.Windows.Forms.TrackBar();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label_carCount = new System.Windows.Forms.Label();
            this.label_truckCount = new System.Windows.Forms.Label();
            this.label_trainCarCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CargoShip2.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(194, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(489, 105);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 45;
            // 
            // track_motorCycles
            // 
            this.track_motorCycles.Location = new System.Drawing.Point(12, 238);
            this.track_motorCycles.Name = "track_motorCycles";
            this.track_motorCycles.Size = new System.Drawing.Size(220, 45);
            this.track_motorCycles.TabIndex = 2;
            this.track_motorCycles.Scroll += new System.EventHandler(this.track_motorCycles_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(12, 349);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(220, 45);
            this.track_cars.TabIndex = 3;
            this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(432, 238);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(220, 45);
            this.track_trucks.TabIndex = 4;
            this.track_trucks.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // track_trainCars
            // 
            this.track_trainCars.Location = new System.Drawing.Point(432, 349);
            this.track_trainCars.Name = "track_trainCars";
            this.track_trainCars.Size = new System.Drawing.Size(220, 45);
            this.track_trainCars.TabIndex = 5;
            this.track_trainCars.Scroll += new System.EventHandler(this.track_trainCars_Scroll);
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Location = new System.Drawing.Point(63, 222);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(35, 13);
            this.label_cycleCount.TabIndex = 6;
            this.label_cycleCount.Text = "label1";
            // 
            // label_carCount
            // 
            this.label_carCount.AutoSize = true;
            this.label_carCount.Location = new System.Drawing.Point(63, 333);
            this.label_carCount.Name = "label_carCount";
            this.label_carCount.Size = new System.Drawing.Size(35, 13);
            this.label_carCount.TabIndex = 8;
            this.label_carCount.Text = "label3";
            // 
            // label_truckCount
            // 
            this.label_truckCount.AutoSize = true;
            this.label_truckCount.Location = new System.Drawing.Point(471, 222);
            this.label_truckCount.Name = "label_truckCount";
            this.label_truckCount.Size = new System.Drawing.Size(35, 13);
            this.label_truckCount.TabIndex = 9;
            this.label_truckCount.Text = "label2";
            // 
            // label_trainCarCount
            // 
            this.label_trainCarCount.AutoSize = true;
            this.label_trainCarCount.Location = new System.Drawing.Point(471, 333);
            this.label_trainCarCount.Name = "label_trainCarCount";
            this.label_trainCarCount.Size = new System.Drawing.Size(35, 13);
            this.label_trainCarCount.TabIndex = 10;
            this.label_trainCarCount.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MotorCylces (3 units)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Car (5 units)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Train Cars (17 units)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trucks (11 units)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "New Ship";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.BackColor = System.Drawing.Color.Black;
            this.label_shipLabel.ForeColor = System.Drawing.Color.White;
            this.label_shipLabel.Location = new System.Drawing.Point(144, 145);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(35, 13);
            this.label_shipLabel.TabIndex = 16;
            this.label_shipLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_trainCarCount);
            this.Controls.Add(this.label_truckCount);
            this.Controls.Add(this.label_carCount);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.track_trainCars);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.track_motorCycles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = " Load the Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.Label label_trainCarCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_shipLabel;
    }
}

