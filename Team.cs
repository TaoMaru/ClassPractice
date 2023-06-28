using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassPractice
{
    class Team
    {
        // Team fields:
        private string name;
        private string[] roster = new string[8];
        private string captain;
        private TeamStatus currentStatus;

        //Team methods:
        public void assignCaptain(string captainName) {
            //assign captain and first team member in roster assigned as captain
            captain = captainName;
            roster[0] = captain;
        }

        public void addMember(string memberName) {
            //add team member to roster
            for (var index = 0; index < roster.Length; ++index) {
                if (roster[index] == null) {
                    roster[index] = memberName;
                    return;
                }
            }
        }

        public void updateName(string teamName) {
            name = teamName;
        }

        public void setStatus(TeamStatus newStatus) {
            currentStatus = newStatus;
        }

        public string getCaptain() {
            return captain;
        }

        public string getName() {
            return name;
        }

        public TeamStatus getStatus() {
            return currentStatus;
        }

        public void printRoster() {
            string teamLineUp = string.Format("Team name: {0} \n Captain: {1}", name, captain);
            for (int index = 1; index < roster.Length; ++index) {
                if (roster[index] != null) {
                    teamLineUp += "\n   " + roster[index];
                        }
            }
            Console.WriteLine(teamLineUp);
        }
    }
}
