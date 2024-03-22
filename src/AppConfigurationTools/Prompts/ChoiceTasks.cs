namespace AppConfigurationTools.Prompts;

internal static class ChoiceTasks
{
    internal static SelectionPrompt<string> Prompt()
    {
        return new SelectionPrompt<string>()
            .Title("작업을 선택하세요.")
            .PageSize(5)
            .AddChoices(new[] { "1. 생성", "1. 조회", "2. 추가", "3. 수정" });
    }
}
