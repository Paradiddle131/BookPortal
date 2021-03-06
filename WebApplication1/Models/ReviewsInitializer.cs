﻿using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BookPortal.Models
{
    public class ReviewsInitializer : DropCreateDatabaseIfModelChanges<ReviewsContext>
	{
		protected override void Seed(ReviewsContext context)
		{
			List<CategoriesDB> categories = new List<CategoriesDB>()
			{
				new CategoriesDB(){CategoryName="Guide"},
				new CategoriesDB(){CategoryName="Science Fiction"},
                new CategoriesDB(){CategoryName="Journals"},
                new CategoriesDB(){CategoryName="Art"},
                new CategoriesDB(){CategoryName="Drama"},
                new CategoriesDB(){CategoryName="Diaries"}
            };

			foreach (var item in categories)
			{
				context.Categories.Add(item);
			}

			context.SaveChanges();
			// BookPortal.Reviev
			//List<Review> reviews = new List<Review>()
			//{
			//    new Review() { BookName="Jules Verne" , BookSubject="life of jules verne", BookWriter="seyfettin", BookAnalysis="güzel", OtherBooks="kasagı", ReviewType="general", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=1 },
			//    new Review() { BookName="sol ayağım" , BookSubject="life of jules verne", BookWriter="raci", BookAnalysis="kötü", OtherBooks="kasagı", ReviewType="character", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=2 },
			//    new Review() { BookName="beyaz diş" , BookSubject="life of jules verne", BookWriter="mehmet", BookAnalysis="orta", OtherBooks="kasagı", ReviewType="general", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=1 }
			//};

			//DataLibrary.RevivewModel
			List<ReviewsDB> reviews = new List<ReviewsDB>()
			{
                new ReviewsDB() { BookName="A Daughter of the Snows" ,Status="top", Confirmation=true, BookSubject="Subject is Daughter of the Snows", AuthorName="Jack ListedVersion", BookAnalysis="Strongly Recommended", OtherBooks="Adventure", ReviewType="Analysis", CategoryId=1, MainPage=true, Picture="daughterofsnow.jpg" , UploadDate=DateTime.Now.AddDays(-10), Content="The novel features a strong female heroine, Frona Welse. Frona was born into a wealthy family and educated at Stanford but she takes to the Yukon trail after upsetting her father and his wealthy community of friends with her out-spoken ways and her innocent friendship with the town's prostitute."},
                new ReviewsDB() { BookName="A Modern Instance" ,Status="none",Confirmation=true, BookSubject="Subject is Modern Instance", AuthorName="Charlies Dickens", BookAnalysis="Mind blowing", OtherBooks="Annie Kilbum", ReviewType="Analysis", CategoryId=2, MainPage=true, Picture="modernınstance.jpg" , UploadDate=DateTime.Now.AddDays(-5), Content="In the novel, Howells uses the divorce theme to portray the widening cultural divisions in American society, and in this way, A Modern Instance anticipates many of Howells’s later novels in both its style and preoccupations. Old and new, rural and urban, life in the West and life in the East, and traditional orthodoxy and modern intellectual skepticism are compared in a series of contrasts which reveal Howells’s concern with the social and economic problems of his time. "},
                new ReviewsDB() { BookName="Hard Times" ,Status="top",Confirmation=true, BookSubject="Subject is Hard Times", AuthorName="Amelia B.Edwards", BookAnalysis="Informative", OtherBooks="Children Blood and Bone", ReviewType="Analysis", CategoryId=1, MainPage=true, Picture="hardtimes.jpg" , UploadDate=DateTime.Now.AddDays(-2), Content="Having Sissy in Gradgrind's house worries Bounderby, who wants to marry teenage Louisa. He fears Sissy will corrupt Louisa, but he is mistaken. Sissy is kind and diligent, except when her father's disappearance overwhelms her. Then, she cannot help but cry. Noticing Sissy's tears one day, Louisa comforts her. Sissy and Louisa then become closer. While Sissy is often criticized at school for delighting in fancy rather than fact, Louisa has discovered she prefers imagination to reason. Nonetheless, when Bounderby, whom Louisa does not love, asks her to marry him, she agrees."},
                new ReviewsDB() { BookName="Pharaohs, Fellahs and Explorers" ,Status="top", Confirmation=true,BookSubject="Subject is Pharaohs", AuthorName="Jack ListedVersion", BookAnalysis="Strongly Recommended", OtherBooks="Adventure", ReviewType="Analysis", CategoryId=5, MainPage=true, Picture="pharaohs.jpg" , UploadDate=DateTime.Now.AddDays(-10), Content="The novel features a strong female heroine, Frona Welse. Frona was born into a wealthy family and educated at Stanford but she takes to the Yukon trail after upsetting her father and his wealthy community of friends with her out-spoken ways and her innocent friendship with the town's prostitute."},
                new ReviewsDB() { BookName="The End of Eternity" ,Status="new", Confirmation=true,BookSubject="Subject is end of the eternity", AuthorName="Charlies Dickens", BookAnalysis="Mind blowing", OtherBooks="Annie Kilbum", ReviewType="Analysis", CategoryId=2, MainPage=true, Picture="eternity.jpg" , UploadDate=DateTime.Now.AddDays(-5), Content="In the novel, Howells uses the divorce theme to portray the widening cultural divisions in American society, and in this way, A Modern Instance anticipates many of Howells’s later novels in both its style and preoccupations. Old and new, rural and urban, life in the West and life in the East, and traditional orthodoxy and modern intellectual skepticism are compared in a series of contrasts which reveal Howells’s concern with the social and economic problems of his time. "},
                new ReviewsDB() { BookName="Children of Bloood and Bone" ,Status="none",Confirmation=true, BookSubject="Subject is children's life", AuthorName="Amelia B.Edwards", BookAnalysis="Informative", OtherBooks="Children Blood and Bone", ReviewType="Analysis", CategoryId=4, MainPage=true, Picture="blood.jpg" , UploadDate=DateTime.Now.AddDays(-2), Content="Having Sissy in Gradgrind's house worries Bounderby, who wants to marry teenage Louisa. He fears Sissy will corrupt Louisa, but he is mistaken. Sissy is kind and diligent, except when her father's disappearance overwhelms her. Then, she cannot help but cry. Noticing Sissy's tears one day, Louisa comforts her. Sissy and Louisa then become closer. While Sissy is often criticized at school for delighting in fancy rather than fact, Louisa has discovered she prefers imagination to reason. Nonetheless, when Bounderby, whom Louisa does not love, asks her to marry him, she agrees."},
                new ReviewsDB() { BookName="The Desert and the Snow" ,Status="new",Confirmation=true, BookSubject="Subject is desert and the snow", AuthorName="Jack ListedVersion", BookAnalysis="Strongly Recommended", OtherBooks="Adventure", ReviewType="Analysis", CategoryId=2, MainPage=true, Picture="desertsnow.jpg" , UploadDate=DateTime.Now.AddDays(-10), Content="The novel features a strong female heroine, Frona Welse. Frona was born into a wealthy family and educated at Stanford but she takes to the Yukon trail after upsetting her father and his wealthy community of friends with her out-spoken ways and her innocent friendship with the town's prostitute."},
                new ReviewsDB() { BookName="The Cocoon: A Rest-Cure Comedy" ,Status="top",Confirmation=true, BookSubject="Subject is cocoon", AuthorName="Charlies Dickens", BookAnalysis="Mind blowing", OtherBooks="Annie Kilbum", ReviewType="Analysis", CategoryId=3, MainPage=true, Picture="cocoon.jpg" , UploadDate=DateTime.Now.AddDays(-5), Content="In the novel, Howells uses the divorce theme to portray the widening cultural divisions in American society, and in this way, A Modern Instance anticipates many of Howells’s later novels in both its style and preoccupations. Old and new, rural and urban, life in the West and life in the East, and traditional orthodoxy and modern intellectual skepticism are compared in a series of contrasts which reveal Howells’s concern with the social and economic problems of his time. "},
                new ReviewsDB() { BookName="A Thousand Miles Up the Nile" ,Status="none", Confirmation=true, BookSubject="Subject is History of the Nile", AuthorName="Amelia B.Edwards", BookAnalysis="Informative", OtherBooks="Children Blood and Bone", ReviewType="Analysis", CategoryId=2, MainPage=true, Picture="nile.jpg" , UploadDate=DateTime.Now.AddDays(-2), Content="Having Sissy in Gradgrind's house worries Bounderby, who wants to marry teenage Louisa. He fears Sissy will corrupt Louisa, but he is mistaken. Sissy is kind and diligent, except when her father's disappearance overwhelms her. Then, she cannot help but cry. Noticing Sissy's tears one day, Louisa comforts her. Sissy and Louisa then become closer. While Sissy is often criticized at school for delighting in fancy rather than fact, Louisa has discovered she prefers imagination to reason. Nonetheless, when Bounderby, whom Louisa does not love, asks her to marry him, she agrees."},
                new ReviewsDB() { BookName="Three Soldiers" ,Status="new", Confirmation=true, BookSubject="Subject is Soldiers", AuthorName="John Dos Passos", BookAnalysis="Informative", OtherBooks="The Game", ReviewType="General", CategoryId=6, MainPage=true, Picture="threesoldiers.jpg" , UploadDate=DateTime.Now.AddDays(-1), Content="I had to see this on the British Airways plane. It was terribly bad acting and a dumb story. Not even a kid would enjoy this. Something to switch off if possible."},
                new ReviewsDB() { BookName="The Freakshow Murders" ,Status="top", Confirmation=true, BookSubject="Subject is Freakshow Murders", AuthorName="Fredric Brown", BookAnalysis="Intriguing", OtherBooks="Ten Tales from the Decameron", ReviewType="General", CategoryId=6, MainPage=true, Picture="murders.jpg" , UploadDate=DateTime.Now.AddDays(-4), Content="The English translation of the title on the DVD version of this film is Graveyard of Horrors, but I think that must be an error. It should have been called Graveyard of Horribles. Horrible acting, horrible editing, horrible story, and horrible music all make this a horrible film best left in a horrible graveyard. Horrible."}
            };

			foreach (var item in reviews)
			{
				context.Reviews.Add(item);
			}

			context.SaveChanges();

			base.Seed(context);
		}
	}
}