﻿using ConventionTemplate.Models;
using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace ConventionTemplate
{
    public partial class ConventionTemplatePage : ContentPage
    {
        public ConventionTemplatePage()
        {
            InitializeComponent();



            PanelList.ItemsSource = new List<PanelGuest> {
                new PanelGuest{name="Henry Cavil", description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a", imageUrl="ConventionTemplate.Images.tomholland.jpg", notes="*APPEARING SATURDAY AND SUNDAY ONLY"},
                new PanelGuest{name="Henry Cavil", description="ahgsfdhjkagsGVDJKHasgvdjhgaSJKHDG", imageUrl="https://unsplash.com/photos/b8rkmfxZjdU", notes="ajhsgdjhasdbfjabfd"},
                new PanelGuest{name="Henry Cavil", description="ahgsfdhjkagsGVDJKHasgvdjhgaSJKHDG", imageUrl="https://unsplash.com/photos/b8rkmfxZjdU", notes="ajhsgdjhasdbfjabfd"}
            };
        }
    }
}
