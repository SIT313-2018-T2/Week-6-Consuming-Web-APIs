using ConferenceSessionsAPIs.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace ConferenceSessionsAPIs.Controllers
{
    public class ConferenceSessionsController : ApiController
    {
        List<Session> sessions = new List<Session>(
            new Session[]
        {
            new Session{SessionTitle = "Microsoft", SessionDescription="Azure!"},
            new Session{SessionTitle = "Google", SessionDescription="Android!"},
            new Session{SessionTitle = "Facebook", SessionDescription="What's APP!"},
            new Session{SessionTitle = "IBM", SessionDescription="Watson"}
        }
        );
        public List<Session> GetAllClass()
        {
            return sessions;
        }
        public Session GetSession(string id)
        {
            var session = sessions.FirstOrDefault((p) => p.SessionTitle == id);
            return session;
        }
    }
}
