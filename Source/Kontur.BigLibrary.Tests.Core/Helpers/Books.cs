using Kontur.BigLibrary.Service.Contracts;

namespace Kontur.BigLibrary.Tests.Core.Helpers;

public static class Books
{
    public static readonly Book EnglishBook = new BookBuilder()
        .WithName("Database Systems. The Complete Book")
        .WithAuthor("Hector Garcia-Molina, Jeffrey D.Ullman, Jennifer Widom")
        .Build();

    public static readonly Book RussianBook =
        new BookBuilder()
            .WithName("Вишневый сад").WithAuthor("Чехов")
            .Build();

    public static readonly Book BookWithLongDescription = new BookBuilder()
        .WithName("Руководство к своду знаний по управлению проектами")
        .WithDescription(
            "Свод знаний по управлению проектам PMBOK представляет собой сумму профессиональных знаний по управлению проектами. Институт управления проектами использует этот документ в качестве основного справочного материала для своих программ по профессиональному развитию.Является Американским национальным стандартом. В настоящее время в пользовании находятся более 2 миллионов экземпляров Руководства PMBOK.C момента выхода четвертого издания Институт управления проектами получил тысячи ценных разъяснений и рекомендаций по улучшению от мирового сообщества руководителей проектов.")
        .Build();
}