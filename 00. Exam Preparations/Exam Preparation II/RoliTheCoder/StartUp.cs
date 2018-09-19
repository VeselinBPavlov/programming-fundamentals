namespace RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var eventRegister = new Dictionary<int, string>();
            var eventParticipans = new Dictionary<string, List<string>>();

            while (command != "Time for Code")
            {
                if (command.Contains("#"))
                {
                    var eventInfo = command
                        .Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    var id = int.Parse(eventInfo[0]);
                    var eventName = eventInfo[1];

                    var participants = new List<string>();

                    for (int i = 2; i < eventInfo.Count; i++)
                    {
                        participants.Add(eventInfo[i]);
                    }
                    if (!eventRegister.ContainsKey(id))
                    {
                        eventRegister.Add(id, eventName);
                        eventParticipans.Add(eventName, participants);
                    }
                    else if (eventRegister[id] == eventName)
                    {
                        eventParticipans[eventName].AddRange(participants);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var eventName in eventParticipans.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{eventName.Key} - {eventName.Value.Distinct().Count()}");
                foreach (var participan in eventName.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine($"{participan}");
                }
            }
        }
    }
}
