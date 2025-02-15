public class ScriptureList
{
    private Dictionary<string, Scripture> scriptures = new Dictionary<string, Scripture>();

    public ScriptureList()
    {
        scriptures.Add("Psalm 23:4", new Scripture(new Reference("John", 23, 16),"Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me."));

        scriptures.Add("Alma 32:21", new Scripture(new Reference("Alma", 32,21),"And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."));
    }

    public Scripture RandomScriptureChosen()
    {
        Random scrip = new Random();
        List<Scripture> scriptureList = scriptures.Values.ToList();
        return scriptureList[scrip.Next(scriptureList.Count)];
    }
}