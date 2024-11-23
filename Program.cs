using Technical_challenge;

string folderPath = @"C:\Users\DELL\Desktop\Technical challenge";
string searchString = "example"; 
FileSearcher fileSearcher = new FileSearcher(folderPath, searchString);
fileSearcher.ScanFiles();

List<int> _collectionA = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
List<int> _collectionS = new List<int> { 5, 15, 3, 19, 35, 50, -1, 0 };

DuplicateIdentifierr<int> duplicateIdentifier = new DuplicateIdentifierr<int>(_collectionA, _collectionS);
duplicateIdentifier.IdentifyDuplicates();
