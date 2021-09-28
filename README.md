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
        
        ![page1Car](https://user-images.githubusercontent.com/48361671/135168487-650883fa-0f74-4ffd-acf9-e0669d6e743c.png)

        
        This is the second page
        
        
        ![page2Car](https://user-images.githubusercontent.com/48361671/135168508-1c382801-364a-4cb1-9f8b-fc3c2f23c160.png)

        
        
        
        
        
        
        
        
