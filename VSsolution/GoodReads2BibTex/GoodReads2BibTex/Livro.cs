using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReads2BibTex
{
    public class Livro
    {
        public String Book_Id;
        public String Title;
        String Author;
        String Author_l_f;
        String Additional_Authors;
        String ISBN;
        String ISBN13;
        String My_Rating;
        String Average_Rating;
        String Publisher;
        String Binding;
        String Number_of_Pages;
        String Year_Published;
        String Original_Publication_Year;
        String Date_Read;
        String Date_Added;
        String Bookshelves;
        String Bookshelves_with_positions;
        String Exclusive_Shelf;
        String My_Review;
        String Spoiler;
        String Private_Notes;
        String Read_Count;
        String Recommended_For;
        String Recommended_By;
        String Owned_Copies;
        String Original_Purchase_Date;
        String Original_Purchase_Location;
        String Condition;
        String Condition_Description;
        String BCID;

        public Livro(String[] vlr)
        {
            Book_Id=vlr[0];
            Title = vlr[1];
            Author = vlr[2];
            Author_l_f = vlr[3];
            Additional_Authors = vlr[4];
            ISBN = vlr[5];
            ISBN13 = vlr[6];
            My_Rating = vlr[7];
            Average_Rating = vlr[8];
            Publisher = vlr[9];
            Binding = vlr[10];
            Number_of_Pages = vlr[11];
            Year_Published = vlr[12];
            Original_Publication_Year = vlr[13];
            Date_Read = vlr[14];
            Date_Added = vlr[15];
            Bookshelves = vlr[16];
            Bookshelves_with_positions = vlr[17];
            Exclusive_Shelf = vlr[18];
            My_Review = vlr[19];
            Spoiler = vlr[20];
            Private_Notes = vlr[21];
            Read_Count = vlr[22];
            Recommended_For = vlr[23];
            Recommended_By = vlr[24];
            Owned_Copies = vlr[25];
            Original_Purchase_Date = vlr[26];
            Original_Purchase_Location = vlr[27];
            Condition = vlr[28];
            Condition_Description = vlr[29];
            BCID = vlr[30];
        }


        public String bibtex()
        {
            /**
            
            @book{Book_Id,
            	title = {Title},
            	isbn = {ISBN},
            	author = {Author, Additional_Authors},
                publisher = {Publisher},
                pages = {Number_of_Pages},
            	year = {Original_Publication_Year},
	            annote = {Notas Goodreads
                          ISBN13
                          My_Rating 
                          Average_Rating
                          Binding
                          Year_Published
                          Date_Read
                          Date_Added
                          Bookshelves
                          Bookshelves_with_positions
                          Exclusive_Shelf
                          My_Review
                          Spoiler
                          Private_Notes
                          Read_Count
                          Recommended_For 
                          Recommended_By
                          Owned_Copies
                          Original_Purchase_Date
                          Original_Purchase_Location
                          Condition
                          Condition_Description
                          BCID
                    }
                 }
             
             */

            String txt = "";
            txt = txt + "\n@book{" +this.Book_Id + ",";
            txt = txt + "\ntitle = {" + this.Title + "},";
            txt = txt + "\nisbn = {" + this.ISBN + "},";
            txt = txt + "\nauthor = {" + this.Author +"},";
            txt = txt + "\nyear = {" + this.Original_Publication_Year + "},";
            txt = txt + "\npublisher = {" + this.Publisher + "},";
            txt = txt + "\npages = {" + this.Number_of_Pages + "}";
           // txt = txt + "\nannote = { GoodReads notes \r\n\tData leitura = " + this.Date_Read
           //                       + "\r\n\tMy rate = " + this.My_Rating + "}";
            txt = txt + "\n}";
            return txt;


        }
            }
}
