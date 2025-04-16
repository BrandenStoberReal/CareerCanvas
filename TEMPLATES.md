# Template Options
CareerCanvas allows you to create custom resume templates out of HTML. To do this, some information needs to be marked so the application knows how to process it.

## Macros
Macros are used to mark the information that needs to be replaced. They are defined in the following format:
```html
{{macro_name}}
```
Where `macro_name` is the name of the macro. The macro names should be `unique`. For macros that are used to replace list information, see the [dynamic macros](#dynamic-macro-implementation) section below.

There are two types of macro types: `static` and `dynamic`.
A `static macro` is a macro that will be replaced with a `static value`. For example, the `{{fullName}}` macro will be replaced with the full name of the resume's owner. `These macros can be defined anywhere in the document without issue`.
A `dynamic macro` is a macro that will be replaced with a `dynamic value`. For example, the `{{jobTitle}}` macro's parent element will be duplicated for every job in the users work history. `The parent elements of these macros require special element IDs`. Read the section on [dynamic macros](#dynamic-macro-implementation) further in this document for details.

Static macros can be defined anywhere in the document. For example, the following is a valid macro:
```html
<p>{{fullName}}</p>
```
This will be replaced with the full name of the resume's owner.

Both macro types can also be defined anywhere in the HTML element. For example, the following is a valid, albeit useless, macro:
```html
<div class="resume">
    <h1 class="{{fullName}}">{{homeAddress}}</h1>
</div>
```
This will replace the `h1` element's class with the user's full name.

Lastly, dynamic macros can be defined anywhere in an element's descendancy. For example, the following is a valid macro:
```html
<li class="educationentry">
    <h3>{{degreeType}} - <strong>{{schoolName}}</strong></h3>
</li>
```
This would correctly replace `{{schoolName}}` and `{{degreeType}}` despite the former being nested inside the `strong` element.


## List of Macros
| Macro Name | Description | Required? | Dynamic? | Placeholder Available? |
| :---: | :---: | :---: | :---: | :---: |
| `{{fullName}}` | The full name of the resume's owner. | Yes | No | No |
| `{{homeAddress}}` | The resume owner's legal residence. | No | No | No |
| `{{emailAddress}}` | The resume owner's email address. | No | No | No |
| `{{phoneNumber}}` | The resume owner's phone number. | No | No | No |
| `{{linkedIn}}` | The resume owner's LinkedIn profile. | No | No | No |
| `{{resumeSummary}}` | A summary of the resume owner's overall job experience. | No | No | Yes |
| `{{skillName}}` | A placeholder for a skill the resume owner posesses. | No | Yes | Yes |
| `{{jobTitle}}` | A placeholder for the job title defined in the owner's work history. | Yes | Yes | No |
| `{{jobDescription}}` | A placeholder for the job description defined in the owner's work history. | No | Yes | No |
| `{{jobStartMonth}}` | A placeholder for the job's starting month as defined in the owner's work history. | Yes | Yes | No |
| `{{jobStartYear}}` | A placeholder for the job's starting year as defined in the owner's work history. | Yes | Yes | No |
| `{{jobEndMonth}}` | A placeholder for the job's ending month as defined in the owner's work history. | Yes | Yes | No |
| `{{jobEndYear}}` | A placeholder for the job's ending year as defined in the owner's work history. | Yes | Yes | No |
| `{{jobCompanyName}}` | A placeholder for the job company defined in the owner's work history. | Yes | Yes | No |
| `{{degreeType}}` | A placeholder for a degree obtained or currently obtaining in the user's educational history. | Yes | Yes | No |
| `{{schoolName}}` | A placeholder for the name of the school where the degree was obtained or is currently being obtained. | Yes | Yes | No |
| `{{schoolStartMonth}}` | A placeholder for the month the degree was started. | Yes | Yes | No |
| `{{schoolStartYear}}` | A placeholder for the year the degree was started. | Yes | Yes | No |
| `{{schoolEndMonth}}` | A placeholder for the month the degree was obtained. | Yes | Yes | No |
| `{{schoolEndYear}}` | A placeholder for the year the degree was obtained. | Yes | Yes | No |
| `{{certificationName}}` | A placeholder for the name of a certification obtained or currently obtaining in the user's educational history. | Yes | Yes | No |
| `{{certificationDate}}` | A placeholder for the date the certification was issued to the user. | Yes | Yes | No |
| `{{certificateIssuingOrganization}}` | A placeholder for the name of the issuer of the certification. | Yes | Yes | No |

## Dynamic Macro Implementation
Dynamic macros are used to create a list of items that are repeated for each item in the list. For example, the `{{jobTitle}}` macro will be replaced with the job title of each job in the user's work history.

For these macros to function properly, a template developer needs to explicitly mark the parent element of the macro with a unique ID. This ID is used to identify the parent element of the macro and is used to duplicate the element for each item in the list.

There are currently four categories for dynamic macros: `education`, `work`, `certification`, and `skills`. Each category has its own set of macros that are used to identify the parent element of the macro.

### Education Container
An example is provided below from one of the default templates:
```html
<div class="section" id="educationsection">
    <h2>Education</h2>
    <ul class="education">
        <li class="educationentry">
            <h3>{{degreeType}} - {{schoolName}}</h3>
            <p>{{schoolStartMonth}} {{schoolStartYear}} - {{schoolEndMonth}} {{schoolEndYear}}</p>
        </li>
    </ul>
</div>
```
Note in the above example, the `section` class is not relevant. Take note of `educationentry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `education` class is not relevant. This is used to style the list of education entries.

Lastly, the `educationsection` ID is used in case a user does not provide any data to fill. In this case, the elements are removed from the document, basing off the children of the `educationsection` element.

### Work Container
An example is provided below from one of the default templates:
```html
    <div class="section" id="experiencesection">
        <h2>Experience</h2>
        <ul class="experience">
            <li class="jobentry">
                <h3>{{jobTitle}} - {{jobCompanyName}}</h3>
                <p>{{jobStartMonth}} {{jobStartYear}} - {{jobEndMonth}} {{jobEndYear}}</p>
                <p>{{jobDescription}}</p>
            </li>
        </ul>
    </div>
```
Note in the above example, the `section` class is not relevant. Take note of `jobentry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `experience` class is not relevant. This is used to style the list of job entries.

Lastly, the `experiencesection` ID is used in case a user does not provide any data to fill. In this case, the elements are removed from the document, basing off the children of the `experiencesection` element.

### Certification Container
An example is provided below from one of the default templates:
```html
<div class="section" id="certificatesection">
    <h2>Certificates</h2>
    <ul class="certificates">
        <li class="certificateentry">
            <h3>{{certificateName}}</h3>
            <p>{{certificateIssuingOrganization}} ({{certificateDate}})</p>
        </li>
    </ul>
</div>
```
Note in the above example, the `section` class is not relevant. Take note of `certificateentry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `certificates` class is not relevant. This is used to style the list of certificate entries.

Lastly, the `certificatesection` ID is used in case a user does not provide any data to fill. In this case, the elements are removed from the document, basing off the children of the `certificatesection` element.

### Skills Container
An example is provided below from one of the default templates:
```html
<div class="section">
    <h2>Skills</h2>
    <ul class="skills" id="skills">
        <li class="skillentry">{{skillName}}</li>
    </ul>
</div>
```
Note in the above example, the `section` class is not relevant. Take note of `skillentry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `skills` class is not relevant. This is used to style the list of skills.

Lastly, the `skills` ID is used in case a user does not provide any data to fill. In this case, the elements are replaced with placeholder skills.

### Example Template Output
Assuming 3 skills are provided, named `HTML`, `CSS`, and `JavaScript`, the application would process them into the following output:
```html
<div class="section">
    <h2>Skills</h2>
    <ul class="skills" id="skills">
        <li class="skillentry">HTML</li>
        <li class="skillentry">CSS</li>
        <li class="skillentry">JavaScript</li>
    </ul>
</div>
```