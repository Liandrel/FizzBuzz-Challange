



















struct DivisableRuleInfo
{
    public string WordToPrint;
    public int[] MustBeDivisableBySet;


    public DivisableRuleInfo(string word, int[] numberSet)
    {
        WordToPrint = word;
        MustBeDivisableBySet = numberSet;
    }
}