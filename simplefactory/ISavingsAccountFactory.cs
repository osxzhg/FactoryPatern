namespace simplefactory
{
    public interface ISavingsAccountFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

}
