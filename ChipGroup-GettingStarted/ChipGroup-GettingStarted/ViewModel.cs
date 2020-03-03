using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ChipGroup_GettingStarted
{
    public class ViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Langugae> languages;
        public ObservableCollection<Langugae> Languages
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

        private ObservableCollection<Langugae> selectedItems;
        public ObservableCollection<Langugae> SelectedItems
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
            Languages = new ObservableCollection<Langugae>();
            Languages.Add(new Langugae() { Name = "C#" });
            Languages.Add(new Langugae() { Name = "HTML" });
            Languages.Add(new Langugae() { Name = "Java" });
            Languages.Add(new Langugae() { Name = "JS" });

            selectedItems = new ObservableCollection<Langugae>() { Languages[0], Languages[1] };

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
