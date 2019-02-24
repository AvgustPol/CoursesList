namespace LearningAspNetCore_CoursesList.Pages.Courses
{
    public static class AlertMessages
    {
        public const string OnCreateMessage = "Created successfully!";
        public const string OnDeleteMessage = "Deleted successfully!";
        public const string OnUpdateMessage = "Updated successfully!";
        public const string ThereIsNoCourseMessage = "There is no course";

        public static string ThereIsNoCourseWithId(int id)
        {
            return $"{ThereIsNoCourseMessage} with id = {id} !";
        }
    }
}