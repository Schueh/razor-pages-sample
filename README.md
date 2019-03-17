# razor-pages-sample
A basic sample of a Razor Pages web application

## Tag helpers

### Environment
* _Layout.cshtml

### Cache
* Index.cshtml

## Forms

### Form tag helper
* Contact.cshtml
* EditBook.cshtml

### Model validation
* Contact.cs (Data Annotations)
* Book.cs (Data Annotations)
* EditBook.cshtml (Form Validation Summary)
* Contact.cshtml (Validation error per input)
* EditBooks.cshtml.cs (OnPost -> check model state)
* Contact.cshtml.cs (OnPost -> check model state)

## Routing and page handlers

### Route templates
* Startup.cs (see AddRazorPagesOptions)
* BookDetail.cshtml (use slug as route parameter instead of id)

### Route constraints
* Built-in route constraint
  * EditBook.cshtml
* Custom route constraint
  * PromoConstraint.cs (definition)
  * Feedback.cshtml (usage)

### Page handlers
* Confirmation.cshtml.cs
* Contact.cshtml.cs (redirect to page with custom page handler)

## Partial views, components and sections

### Partial views
* ReusableWidget.cshtml (definition)
* Index.cshtml (usage)

### View components
* Components/RecentBooks/Default.cshtml
* RecentBooks.cs
* Index.cshtml (usage)

### Sections
* _Layout.cshtml (definition)
* Books.cshtml (usage)

## Misc

### Dependency injection
* Startup.cs (see ConfigureServices)
* IBookService.cs
* Books.cshtml.cs

### Logging
* Books.cshtml.cs

### Health check
* Startup.cs (see ConfigureServices and Configure)


