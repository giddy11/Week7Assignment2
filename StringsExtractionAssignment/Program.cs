// See https://aka.ms/new-console-template for more information

var fileDatas = "Starlight is the light emitted by stars.[1] It typically refers to visible electromagnetic radiation from stars other than the\n\n" +
               "Sun,observable from earth at night,although a component of starlight is observable from earth during daytime.\n\n\n" +
               "Sunlight is the term used for the sun's starlight observed during daytime.[2] During nighttime,albedo describe solar\n\n" +
               "reflections from other Solar System objects,including moonlight,planet shine,and zodiacal light.[3]\n\n\n\n\n";


var fileData = fileDatas.ToLower();

var extractObservable = fileData.Substring(fileData.IndexOf("observable"), 25);
var extractBefore = fileData.Substring(fileData.IndexOf("reflection"), 10);
var merged = String.Concat(extractObservable, extractBefore);
var replaceSun = fileData.Replace("Sun", "Solar Emission");
//Console.WriteLine(replaceSun);

var sentences = fileData.Split('.');
var mergeFirstLast = String.Join(". ", sentences[0], sentences[sentences.Length-1]);

string refNumber1 = sentences[1].Substring(0, 3);
string refNumber2 = sentences[3].Substring(0, 3);
string refNumber3 = sentences[4].Substring(0, 3);


//Console.WriteLine(refNumber3);

var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

var consonants = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 
                                  'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 
                                  'x', 'y', 'z'};

var numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
var sCharacters = new List<char> { '[', ']', '.', ',', '\'', '\"'};

var vowelCharacters = new List<char>();
var consonantCharacters = new List<char>();
var numberCharacters = new List<char>();
var specialCharacters = new List<char>();

foreach (var item in replaceSun)
{
    if (vowels.Contains(item))              vowelCharacters.Add(item);
    if (consonants.Contains(item))          consonantCharacters.Add(item);
    if (numbers.Contains(item))             numberCharacters.Add(item);
    if (specialCharacters.Contains(item))   specialCharacters.Add(item);
}