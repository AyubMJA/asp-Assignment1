# asp-Assignment1
Cars applications.

This application is created using asp.net model-view-controller template. using a sqlite db -- Microsoft SQL Server Management Studio.
this requires cars.db which can be created 

Car module file:
          
        [Key]
        public int ID { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Colour { get; set; }

        public int Year { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Purchase")]

        public DateTime? PurchaseDate { get; set; }

        [Range(0, 999999)]
        public int Kilometers { get; set; }
        
        
        This is the First Page
        
   ![page1Car](https://user-images.githubusercontent.com/48361671/135168838-77c27e5c-c2d5-49e1-8a5a-823974531344.png)
   
        This is the Second Page
   ![page2Car](https://user-images.githubusercontent.com/48361671/135169024-cdaefd08-4a4b-4f13-93f3-af946fd79f21.png)



        
       

        
        
        
        
        
        
        
        
