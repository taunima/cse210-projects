public class Reception : Event
{
    private bool _rsvp;

    public Reception(string title, string description, string date, string time, string address, bool rsvp): base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override string DisplayFullSummary()
    {
        return $"{DisplayFullSummary()} Email for RSVP: {_rsvp}";
    }
}