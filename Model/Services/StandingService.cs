using Model.DTO;
using Model.Entities;
using Model.Interfaces;

namespace Model.Services
{
    public class StandingService
    {
        private readonly IStandingRepository _standingRepository;
        private readonly IMatchRepository _matchRepository;

        public StandingService(
            IStandingRepository standingRepository,
            IMatchRepository matchRepository
        )
        {
            _standingRepository = standingRepository;
            _matchRepository = matchRepository;
        }

        public async Task<Standing> InsertAndGetStandingByClubId(int clubId, int tournamentId)
        {
            var clubStd = await _standingRepository.GetStandingByClubId(clubId);

            if (clubStd == null) 
            {
                Standing newStanding = new Standing
                {
                    ClubId = clubId,
                    TournamentId = tournamentId
                };

                await _standingRepository.Add(newStanding);
                await _standingRepository.SaveChangesAsync();
            }

            return clubStd;
        }

        public async Task SetResultInStandings(Match match, Standing club1std, Standing club2Std, SetMatchResultsDto resultsDto)
        {
            // Independent of the result
            SetClubMatchStanding(match, club1std, resultsDto.ScoreClub1, resultsDto.ScoreClub2);
            SetClubMatchStanding(match, club2Std, resultsDto.ScoreClub2, resultsDto.ScoreClub1);

            // Dependent of the result
            SetClubScoreStanding(match, club1std, resultsDto.ScoreClub1, club2Std, resultsDto.ScoreClub2);

            // Save changes
            _matchRepository.Edit(match);
            await _matchRepository.SaveChangesAsync();

            _standingRepository.Edit(club1std);
            _standingRepository.Edit(club2Std);
            await _standingRepository.SaveChangesAsync();
        }

        private void SetClubMatchStanding(Match match, Standing clubStd, int goals, int goalsAgainst) 
        {
            if (clubStd.Matches == null)
            {
                clubStd.Matches = new List<Match>();
            }
            clubStd.Matches.Add(match);
            clubStd.GoalsFor += goals;
            clubStd.GoalsAgainst += goalsAgainst;
            clubStd.PlayedMatches += 1;
        }

        private void SetClubScoreStanding(Match match, Standing stdClub1, int scoreClub1, Standing stdClub2, int scoreClub2)
        {
            if (scoreClub1 > scoreClub2)
            {
                stdClub1.Wins += 1;
                stdClub1.Points += 3;
                
                match.Winner = match.Club1;

                stdClub2.Losses += 1;
            }
            else if (scoreClub2 > scoreClub1)
            {
                stdClub2.Wins += 1;
                stdClub2.Points += 3;

                match.Winner = match.Club2;

                stdClub1.Losses += 1;
            } 
            else
            {
                stdClub1.Draws += 1;
                stdClub1.Points += 1;

                stdClub2.Draws += 1;
                stdClub2.Points += 1;
            }
        }
    }
}
