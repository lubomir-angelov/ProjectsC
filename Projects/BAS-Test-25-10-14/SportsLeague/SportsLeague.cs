using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Task 2 -- Assuming that we have to make a tournament (direct elliminations), not league (two games per pair) --> 
//Instructions not clear -- League and Tournament mentioned in the Task description

namespace SportsLeague
{
    class SportsLeague
    {
        class League
        {
            public class Match
            {
                public string HomeTeam { get; set; }
                public string GuestTeam { get; set; }

                public Match() { }
                public Match(string homeTeam, string guestTeam)
                {
                    this.HomeTeam = homeTeam;
                    this.GuestTeam = guestTeam;
                }
            }

            public class Round
            {
                public List<Match> Matches { get; set; }

                public Round() { }
                public Round(List<Match> matches) {
                    this.Matches = new List<Match>(matches);
                }
            }

            public List<Round> Rounds;

            public League() { }
            public League(List<Round> rounds)
            {
                this.Rounds = new List<Round>(rounds);
            }

            public List<Round> createLeague(List<string> Teams)
            {
               
                List<Round> rounds = new List<Round>();//end result
                int roundsToBePlayed = (int) Math.Ceiling((double)Teams.Count/2);
                Random rnd = new Random();//a random number instance for determining the winner
                List<string> currentlyPlaying = new List<string>(Teams);

                while (roundsToBePlayed > 0)
                {
                    int matchCount = 0;
                    int[] wins = new int[currentlyPlaying.Count];//an array with enumeration for each team and value the number of a randomly chosen win between two teams (eg. wins[3] = 5 == Team3 has 5 random wins)

                    for (int i = currentlyPlaying.Count - 1; i > 0; i--)
                    {
                        matchCount += i;
                    }

                    List<Match> currentRound = new List<Match>();
                    int homeTeam = 0;//start with the first team and pair it with all the others

                    while (matchCount > 0)
                    {
                        int guestTeam = currentlyPlaying.Count - 1;//start pairing from the last team    
                        
                        //create the matches for the round
                        do
                        {
                            Match currentMatch = new Match(currentlyPlaying[homeTeam], currentlyPlaying[guestTeam]);
                            currentRound.Add(currentMatch);
                            //determine winner by random 
                            //not really working cause of "tight loop" fixable? --> http://stackoverflow.com/questions/767999/random-number-generator-only-generating-one-random-number
                            int randomNumber = rnd.Next(1, 2);
                            if (randomNumber == 1)
                            {
                                wins[homeTeam]++;
                            }
                            else
                            {
                                wins[guestTeam]++;
                            }
                            guestTeam--;
                            matchCount--;
                        } while (guestTeam > homeTeam);//pair until we reach the team that is one number above the current home team
                        homeTeam++;//move up to the next team to play the most matches 
                    }

                    Round roundToAd = new Round(currentRound);//create the object for the current round
                    rounds.Add(roundToAd);//add the object to the result list
                    roundsToBePlayed--; //get down to the next round

                    //extract the winning teams 
                    int toGoOn = (int)Math.Ceiling((double)currentlyPlaying.Count / 2); //number of teams to go on to the next round
                    currentlyPlaying = new List<string>();//clear the list of currently playing

                    //put the winning teams in the list of currently playing
                    int chosen = 0;
                    while (chosen != toGoOn)
                    {
                        int max = wins[0];
                        int index = 0;
                        for (int i = 0; i < wins.Length; i++)
                        {
                            if (max < wins[i])
                            {
                                max = wins[i];
                                index = i;
                            }
                        }
                        currentlyPlaying.Add(Teams[index]);
                        wins[index] = 0;
                        chosen++;
                    }

                }

                Console.WriteLine();//here for debugging purposes
                return rounds;
            }

            
        }
        static void Main(string[] args)
        {
            List<string> teams = new List<string>();//using List<string> because it seems closest to <vector> in C++ (dynamic array) --> http://www.cplusplus.com/reference/vector/vector/
            teams.Add("Levski");
            teams.Add("CSKA");
            teams.Add("Slavia");
            teams.Add("Ludogorets");

            League league = new League();
            league.Rounds = league.createLeague(teams);
            Console.WriteLine();
        }
    }
}
