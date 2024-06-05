using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiCollectionViewBug
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Records> recordsList;

        public MainPageViewModel()
        {
            RecordsList = [
        new Records { RecId=1,Name="User1",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 1"},
        new Records { RecId=2,Name="User2",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 2"},
        new Records { RecId=3,Name="User3",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 3"},
        new Records { RecId=4,Name="User4",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 4"},
        new Records { RecId=5,Name="User5",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 5"},
        new Records { RecId=6,Name="User6",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 6"},
        new Records { RecId=7,Name="User7",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 7"},
        new Records { RecId=8,Name="User8",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 8"},
        new Records { RecId=9,Name="User9",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 9"},
        new Records { RecId=10,Name="User10",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 10"},
        new Records { RecId=11,Name="User11",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 11"},
        new Records { RecId=12,Name="User12",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 12"},
          new Records { RecId=13,Name="User13",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 13"},
        new Records { RecId=14,Name="User14",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 14"},
        new Records { RecId=15,Name="User15",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 15"},
        new Records { RecId=16,Name="User16",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 16"},
        new Records { RecId=17,Name="User17",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 17"},
        new Records { RecId=18,Name="User18",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 18"},
        new Records { RecId=19,Name="User19",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 19"},
        new Records { RecId=20,Name="User20",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 20"},
        new Records { RecId=21,Name="User21",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 21"},
        new Records { RecId=22,Name="User22",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 22"},
        new Records { RecId=23,Name="User23",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 23"},
        new Records { RecId=24,Name="User24",Status="New",SubmittedDate="June 05,2024",CurrentStatus="Stage 24"}
        ];
        }
    }
}
