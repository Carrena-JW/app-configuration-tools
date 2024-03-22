
using AppConfigurationTools.Prompts;
using AppConfigurationTools.Services;

var selectedTask = AnsiConsole.Prompt(ChoiceTasks.Prompt());





var dbFilePaths = DetectingDatabaseFiles.GetDbFilePaths();


AnsiConsole.WriteLine($"당신이 선택한 과일: {selectedTask}");
