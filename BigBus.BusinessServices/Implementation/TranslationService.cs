using BigBus.BusinessServices.Infrastructure;


namespace BigBus.BusinessServices.Implementation
{
    public class TranslationService : ITranslationService
    {
        public string TranslateTerm(string termId)
        {
            return termId;
        }
    }
}
