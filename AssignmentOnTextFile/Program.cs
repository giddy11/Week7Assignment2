// See https://aka.ms/new-console-template for more information
using AssignmentOnTextFile;

var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Directory.CreateDirectory(Path.Combine(path, "Model"));
var model_path = Path.Combine(path, "Model");
//File.Create(Path.Combine(model_path, "csvFile.csv"));

#region Writing to csv File

#region Data1
var model3_1 = new AssignmentModel3
{
    Id = 103,
    AssignmentName = "Exception",
    AssignmentLocation = "Rivers"
};

var model2_1 = new AssignmentModel2
{
    Id = 102,
    AssignmentName = "Loop",
    AssignmentLocation = "Abia",
    AssignmentModel3 = model3_1
};

var model1_1 = new AssignmentModel1
{
    Id = 101,
    AssignmentName = "Text File",
    AssignmentLocation = "Bayelsa",
    AssignmentModel2 = model2_1
};
#endregion
#region Data2
var model3_2 = new AssignmentModel3
{
    Id = 106,
    AssignmentName = "C#",
    AssignmentLocation = "Anambra"
};

var model2_2 = new AssignmentModel2
{
    Id = 105,
    AssignmentName = "Recursion",
    AssignmentLocation = "Bauchi",
    AssignmentModel3 = model3_2
};

var model1_2 = new AssignmentModel1
{
    Id = 104,
    AssignmentName = "Data Structure",
    AssignmentLocation = "Abuja",
    AssignmentModel2 = model2_2
};
#endregion
#region Data3
var model3_3 = new AssignmentModel3
{
    Id = 109,
    AssignmentName = "Programming",
    AssignmentLocation = "Benue"
};

var model2_3 = new AssignmentModel2
{
    Id = 108,
    AssignmentName = "Strings",
    AssignmentLocation = "Ibadan",
    AssignmentModel3 = model3_3
};

var model1_3 = new AssignmentModel1
{
    Id = 107,
    AssignmentName = "While-Loop",
    AssignmentLocation = "Borno",
    AssignmentModel2 = model2_3
};
#endregion

File.AppendAllText(Path.Combine(model_path, "csvFile.csv"), $"{model1_1.Id},{model1_1.AssignmentName},{model1_1.AssignmentLocation},{model1_1.AssignmentModel2.Id},{model1_1.AssignmentModel2.AssignmentName},{model1_1.AssignmentModel2.AssignmentLocation},{model1_1.AssignmentModel2.AssignmentModel3.Id},{model1_1.AssignmentModel2.AssignmentModel3.AssignmentName},{model1_1.AssignmentModel2.AssignmentModel3.AssignmentLocation}\n");

File.AppendAllText(Path.Combine(model_path, "csvFile.csv"), $"{model1_2.Id},{model1_2.AssignmentName},{model1_2.AssignmentLocation},{model1_2.AssignmentModel2.Id},{model1_2.AssignmentModel2.AssignmentName},{model1_2.AssignmentModel2.AssignmentLocation},{model1_2.AssignmentModel2.AssignmentModel3.Id},{model1_2.AssignmentModel2.AssignmentModel3.AssignmentName},{model1_2.AssignmentModel2.AssignmentModel3.AssignmentLocation}\n");

File.AppendAllText(Path.Combine(model_path, "csvFile.csv"), $"{model1_3.Id},{model1_3.AssignmentName},{model1_3.AssignmentLocation},{model1_3.AssignmentModel2.Id},{model1_3.AssignmentModel2.AssignmentName},{model1_3.AssignmentModel2.AssignmentLocation},{model1_3.AssignmentModel2.AssignmentModel3.Id},{model1_3.AssignmentModel2.AssignmentModel3.AssignmentName},{model1_3.AssignmentModel2.AssignmentModel3.AssignmentLocation}\n");

#endregion


#region Reading From csv File

var CSV_path1 = Path.Combine(model_path, "csvFile.csv");

var readFileData = new List<AssignmentModel1>();
var csv_read_lines = File.ReadAllLines(Path.Combine(CSV_path1));

foreach (var item in csv_read_lines)
{
    var itemSplit = item.Split(',');
    readFileData.Add(new AssignmentModel1
    {
        Id = int.Parse(itemSplit[0]),
        AssignmentName = itemSplit[1],
        AssignmentLocation = itemSplit[2],
        AssignmentModel2 = new AssignmentModel2
        {
            Id = int.Parse(itemSplit[3]),
            AssignmentName = itemSplit[4],
            AssignmentLocation = itemSplit[5],
            AssignmentModel3 = new AssignmentModel3
            {
                Id = int.Parse(itemSplit[6]),
                AssignmentName = itemSplit[7],
                AssignmentLocation = itemSplit[8],
            }
        }
    });
}
#endregion


Console.ReadLine();