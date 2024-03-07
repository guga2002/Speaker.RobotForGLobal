

using Speaker.leison.Kontext;

namespace Repositories
{
    public abstract class BaseRepository
    {
        public readonly SpeakerDb database;
        protected BaseRepository()
        {
            this.database = new SpeakerDb();
        }


    }
}
