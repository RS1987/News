using System.Data.Entity;

namespace News.AppContext
{
	public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
	{
		protected override void Seed(AppDbContext context)
		{
			context.News.Add(new Entities.News { Title = "Varius Gravida Mi Volutpat", Article = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tempor, tortor at vulputate blandit, magna risus posuere turpis, nec cursus ipsum arcu nec felis. Mauris sed lectus dui. Suspendisse enim elit, tempor ac ullamcorper et, eleifend quis sem. Sed euismod sagittis ligula, a imperdiet sapien molestie nec. Curabitur ut eros a justo fermentum vulputate ac sit amet metus." });
			context.News.Add(new Entities.News { Title = "Tortor at Vulputate Blandit", Article = "Aenean quis dignissim diam. Etiam venenatis congue velit, varius gravida mi volutpat ac. Sed ut pretium dolor. Etiam tempor felis ac eros dictum quis consectetur dolor tristique. Aliquam scelerisque, odio vel luctus commodo, nisl nisl vehicula metus, ut lobortis eros sem blandit est." });
			context.News.Add(new Entities.News { Title = "Curabitur ut Eros a Justo Fermentum Vulputate", Article = "Etiam tempor felis ac eros dictum quis consectetur dolor tristique. Aliquam scelerisque, odio vel luctus commodo, nisl nisl vehicula metus, ut lobortis eros sem blandit est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tempor, tortor at vulputate blandit, magna risus posuere turpis." });
			context.News.Add(new Entities.News { Title = "Fermentum Vulputate Ac Sit Amet Metus", Article = "Mauris sed lectus dui. Suspendisse enim elit, tempor ac ullamcorper et, eleifend quis sem. Sed euismod sagittis ligula, a imperdiet sapien molestie nec. Curabitur ut eros a justo fermentum vulputate ac sit amet metus. Aenean quis dignissim diam." });
			context.News.Add(new Entities.News { Title = "Aenean Quis Dignissim Diam", Article = "Vulputate ac sit aenean quis dignissim diam. Etiam venenatis congue velit, varius gravida mi volutpat ac. Sed ut pretium dolor. Etiam tempor felis ac eros dictum quis consectetur dolor tristique. Aliquam scelerisque, odio vel luctus commodo, nisl nisl vehicula metus, ut lobortis eros sem blandit est." });
			context.News.Add(new Entities.News { Title = "Tortor at Vulputate Blandit", Article = "Aenean quis dignissim diam. Etiam venenatis congue velit, varius gravida mi volutpat ac. Sed ut pretium dolor. Etiam tempor felis ac eros dictum quis consectetur dolor tristique. Aliquam scelerisque, odio vel luctus commodo, nisl nisl vehicula metus, ut lobortis eros sem blandit est." });
			context.News.Add(new Entities.News { Title = "Curabitur ut Eros a Justo Fermentum Vulputate", Article = "Etiam tempor felis ac eros dictum quis consectetur dolor tristique. Aliquam scelerisque, odio vel luctus commodo, nisl nisl vehicula metus, ut lobortis eros sem blandit est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tempor, tortor at vulputate blandit, magna risus posuere turpis." });

			context.SaveChanges();
		}
	}
}