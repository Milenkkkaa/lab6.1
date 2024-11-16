﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6._1
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSide.Text); // Довжина сторони основи піраміди
            double h = double.Parse(txtHeight.Text); // Висота піраміди
            double r = double.Parse(txtRadius.Text); // Радіус кулі

            // Створюємо об'єкти класів Pyramid і Sphere
            Solid pyramid = new Pyramid(a, h);
            Solid sphere = new Sphere(r);

            // Обчислюємо об'єми
            double pyramidVolume = pyramid.GetVolume();
            double sphereVolume = sphere.GetVolume();

            // Виводимо об'єми на форму
            lblPyramidVolume.Text = pyramidVolume.ToString("0.##");
            lblSphereVolume.Text = sphereVolume.ToString("0.##");
        }
    }
}