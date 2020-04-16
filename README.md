# Multiple selection in Syncfusion ChipGroup
This demo explains about how to select more than one chips in Syncfusion ChipGroup
[How to select a multiple chips from the Xamarin ChipGroup [SfChipGroup]
](https://www.syncfusion.com/kb/11155/?utm_medium=listing&utm_source=github-examples)

This article shows how to choose multiple chips from the Xamarin.Forms SfChipGroup. You can programmatically select the chips by using the SelectedItems property.

Let us have a use case to select more than one language from the list. To achieve those, populate the desired list and predefined selected items from the view model class as follows.

**XAML:**
```
  <buttons:SfChipGroup 
                Type="Filter"   
                ItemsSource="{Binding Languages}"
                SelectedChipBackgroundColor="Red"
                ChipPadding="8,8,0,0"
                SelectionIndicatorColor="White"
                SelectedItems="{Binding SelectedItems}"
   DisplayMemberPath="Name">
  </buttons:SfChipGroup>
  
```
**C#:**
```
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
 
            selectedItems = new ObservableCollection<Language>() { Languages[0], Languages[1]     };
 
        }
…
    }
   
```
Also refer our [feature tour](https://www.syncfusion.com/xamarin-ui-controls/xamarin-chips) page to know more features available in our chips.
## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
