
class Executioner : INpcEvent
{
    public override void Say(NpcEvent e)
    {
        e.npc.Say("I have no time to talk, citizen. Please, step aside! ");
    }

    public override void WaypointArrive(NpcEvent e)
    {
        var waypoint = int.Parse(e.data);
        e.logSys.QuestDebug($"Executioner reaches waypoint: {waypoint}");

        if (waypoint == 14)
        {
            e.npc.Say("Sir. You called for me?");
            e.questManager.signal(1068, 1);
        }
        else if (waypoint == 40)
        {
            e.npc.Say("McNeal Jocub? You have been found guilty of crimes against the city of Qeynos.");
        }
        else if (waypoint == 41)
        {
            e.questManager.signal(1099, 1);
        }
    }

    public override void Signal(NpcEvent e)
    {
        e.npc.Say("Aye sir!");
    }

}
