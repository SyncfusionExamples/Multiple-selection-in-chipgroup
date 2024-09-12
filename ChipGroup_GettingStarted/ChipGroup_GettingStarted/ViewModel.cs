﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ChipGroup_GettingStarted
{
    public class ViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Language> languages;
        public ObservableCollection<Language> Languages
        {
            get
            {
                return languages;
            }
            set
            {
                languages = value;
                OnPropertyChanged("Languages");
            }
        }

        private ObservableCollection<Language> selectedItems;
        public ObservableCollection<Language> SelectedItems
        {
            get
            {
                return selectedItems;
            }
            set
            {
                selectedItems = value;
                OnPropertyChanged("SelectedItems");
            }
        }

        public ViewModel()
        {
            Languages = new ObservableCollection<Language>();
            Languages.Add(new Language() { Name = "C#" });
            Languages.Add(new Language() { Name = "HTML" });
            Languages.Add(new Language() { Name = "Java" });
            Languages.Add(new Language() { Name = "JS" });

            selectedItems = new ObservableCollection<Language>() { Languages[0], Languages[1] };

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
