namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// The team competing.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// The score of the team for this matchup.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// The matchup that it one in the previous round.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}