# Table of Contents
<!--TOC-->
- [Template Options](#template-options)
  - [Macros](#macros)
  - ['Required' Macro Foreword](#required-macro-foreword)
  - [List of Macros](#list-of-macros)
  - [Static Macro Implementation](#static-macro-implementation)
  - [Static Macro IDs](#static-macro-ids)
  - [Dynamic Macro Implementation](#dynamic-macro-implementation)
  - [Dynamic Macro IDs](#dynamic-macro-ids)
    - [Dynamic Macro Section IDs](#dynamic-macro-section-ids)
    - [Dynamic Macro Entry IDs](#dynamic-macro-entry-ids)
  - [Examples](#examples)
    - [Education Container](#education-container)
    - [Work Container](#work-container)
    - [Certification Container](#certification-container)
    - [Skills Container](#skills-container)
    - [Example Template Output](#example-template-output)
<!--/TOC-->

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
<li class="education-entry">
    <h3>{{degreeType}} - <strong>{{schoolName}}</strong></h3>
</li>
```
This would correctly replace `{{schoolName}}` and `{{degreeType}}` despite the former being nested inside the `strong` element.

## 'Required' Macro Foreword
Some macros are listed as `required` in the table below. Despite the name, these macros are not inherently forced to be in the resume; however, macros marked with the `required` entry are strongly recommended to include, as they typically compose the foundation of the document or are otherwise integral information. The application `will still load your template` if a required macro remains undefined, however, your template will likely look very bad.


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
| `{{jobStartMonth}}` | A placeholder for the job's starting month as defined in the owner's work history. | No | Yes | No |
| `{{jobStartMonthShort}}` | A placeholder for the job's starting month as defined in the owner's work history (shortened month name). | No | Yes | No |
| `{{jobStartYear}}` | A placeholder for the job's starting year as defined in the owner's work history. | No | Yes | No |
| `{{jobEndMonth}}` | A placeholder for the job's ending month as defined in the owner's work history. | No | Yes | No |
| `{{jobEndMonthShort}}` | A placeholder for the job's ending month as defined in the owner's work history (shortened month name). | No | Yes | No |
| `{{jobEndYear}}` | A placeholder for the job's ending year as defined in the owner's work history. | No | Yes | No |
| `{{jobStartDate}}` | A placeholder for the job's starting date (MMM yyyy) as defined in the owner's work history. | No | Yes | No |
| `{{jobEndDate}}` | A placeholder for the job's ending date (MMM yyyy) as defined in the owner's work history. | No | Yes | No |
| `{{jobCompanyName}}` | A placeholder for the job company defined in the owner's work history. | Yes | Yes | No |
| `{{degreeType}}` | A placeholder for a degree obtained or currently obtaining in the user's educational history. | Yes | Yes | No |
| `{{schoolName}}` | A placeholder for the name of the school where the degree was obtained or is currently being obtained. | Yes | Yes | No |
| `{{schoolStartMonth}}` | A placeholder for the month the degree was started. | No | Yes | No |
| `{{schoolStartMonthShort}}` | A placeholder for the month the degree was started (shortened month name). | No | Yes | No |
| `{{schoolStartYear}}` | A placeholder for the year the degree was started. | No | Yes | No |
| `{{schoolEndMonth}}` | A placeholder for the month the degree was obtained. | No | Yes | No |
| `{{schoolEndMonthShort}}` | A placeholder for the month the degree was obtained (shortened month name). | No | Yes | No |
| `{{schoolEndYear}}` | A placeholder for the year the degree was obtained. | No | Yes | No |
| `{{schoolStartDate}}` | A placeholder for the date the degree was started (MMM yyyy). | No | Yes | No |
| `{{schoolEndDate}}` | A placeholder for the date the degree was obtained (MMM yyyy). | No | Yes | No |
| `{{certificationName}}` | A placeholder for the name of a certification obtained or currently obtaining in the user's educational history. | Yes | Yes | No |
| `{{certificateMonth}}` | A placeholder for the month the certificate was issued. | No | Yes | No |
| `{{certificateMonthShort}}` | A placeholder for the month the certificate was issued (shortened month name). | No | Yes | No |
| `{{certificateYear}}` | A placeholder for the year the certificate was issued. | No | Yes | No |
| `{{certificateDate}}` | A placeholder for the date the certificate was issued to the user. | No | Yes | No |
| `{{certificateIssuingOrganization}}` | A placeholder for the name of the issuer of the certificate. | Yes | Yes | No |

## Static Macro Implementation
Static macros are required to be assigned a unique ID. This is used to delete the macro's parent element if the user does not provide relevant data. Each static macro has its own ID, which is used to identify the parent element of the macro and delete/modify it if needed.

## Static Macro IDs
| Macro Name | ID |
| :---: | :---: |
| `{{fullName}}` | `name` |
| `{{homeAddress}}` | `address` |
| `{{emailAddress}}` | `email` |
| `{{phoneNumber}}` | `phonenumber` |
| `{{linkedIn}}` | `linkedin` |
| `{{resumeSummary}}` | `professional-summary` |

## Dynamic Macro Implementation
Dynamic macros are used to create a list of items that are repeated for each item in the list. For example, the `{{jobTitle}}` macro will be replaced with the job title of each job in the user's work history.

For these macros to function properly, a template developer needs to explicitly mark the parent element of the macro with a [unique ID](#dynamic-macro-ids).

There are currently four categories for dynamic macros: `education`, `work`, `certification`, and `skills`. Each category has its own set of macros that are used to identify the parent element of the macro.

Dynamic macros are always replaced `recursively` as long as the criteria for the parent element is met. This means that if a dynamic macro's element is nested inside another dynamic macro's element, both macros would be filled regardless of the hierarchy.

## Dynamic Macro IDs
Some hardcoded HTML element IDs are required to be present in the template. These IDs are used to identify the parent element of the macro and are used to duplicate the element for each item in the list. The IDs are also used to delete the parent element if the user does not provide relevant data, and other assorted things.

Please note that any ID marked as 'required' `must be present` in the template. If the ID is not present, the application will not correctly replace the macros and the template will not be valid. The application will still load the template, but it will not be able to replace the macros.

### Dynamic Macro Section IDs
These IDs are used to delete an applicable section if the user has no data pertaining to that section. This allows the final document to be cleaner, more readable, and more professional.

Optional sections serve no purpose besides for consistency and can be removed/excluded from the template if desired. The application will still function correctly without them.

| Section Name | ID | Required? |
| :---: | :---: | :---: |
| Employment Summary Section | `summary-section` | Yes |
| Education Section | `education-section` | Yes |
| Work Experience Section | `experience-section` | Yes |
| Certification Section | `certificate-section` | Yes |
| Skills Section | `skills-section` | No |
| Contact Information Section | `contact-section` | No |

### Dynamic Macro Entry IDs
These IDs are used to replace the macros located as a descendant of the element with the ID.

| Entry Name | ID | Required? |
| :---: | :---: | :---: |
| Education Entry | `education-entry` | Yes |
| Work Entry | `job-entry` | Yes |
| Certification Entry | `certificate-entry` | Yes |
| Skills Entry | `skill-entry` | Yes |

## Examples
### Education Container
An example is provided below from one of the default templates:
```html
<div class="section" id="education-section">
    <h2>Education</h2>
    <ul class="education">
        <li class="education-entry">
            <h3>{{degreeType}} - {{schoolName}}</h3>
            <p>{{schoolStartMonth}} {{schoolStartYear}} - {{schoolEndMonth}} {{schoolEndYear}}</p>
        </li>
    </ul>
</div>
```
Note in the above example, the `section` class is not relevant. Take note of `education-entry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `education` class is not relevant. This is used to style the list of education entries.

Lastly, the `education-section` ID is used in case a user does not provide any data to fill. In this case, the elements are removed from the document, basing off the children of the `education-section` element.

### Work Container
An example is provided below from one of the default templates:
```html
    <div class="section" id="experience-section">
        <h2>Experience</h2>
        <ul class="experience">
            <li class="job-entry">
                <h3>{{jobTitle}} - {{jobCompanyName}}</h3>
                <p>{{jobStartMonth}} {{jobStartYear}} - {{jobEndMonth}} {{jobEndYear}}</p>
                <p>{{jobDescription}}</p>
            </li>
        </ul>
    </div>
```
Note in the above example, the `section` class is not relevant. Take note of `job-entry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `experience` class is not relevant. This is used to style the list of job entries.

Lastly, the `experience-section` ID is used in case a user does not provide any data to fill. In this case, the elements are removed from the document, basing off the children of the `experience-section` element.

### Certification Container
An example is provided below from one of the default templates:
```html
<div class="section" id="certificate-section">
    <h2>Certificates</h2>
    <ul class="certificates">
        <li class="certificate-entry">
            <h3>{{certificateName}}</h3>
            <p>{{certificateIssuingOrganization}} ({{certificateDate}})</p>
        </li>
    </ul>
</div>
```
Note in the above example, the `section` class is not relevant. Take note of `certificate-entry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `certificates` class is not relevant. This is used to style the list of certificate entries.

Lastly, the `certificate-section` ID is used in case a user does not provide any data to fill. In this case, the elements are removed from the document, basing off the children of the `certificate-section` element.

### Skills Container
An example is provided below from one of the default templates:
```html
<div class="section" id="skills-section">
    <h2>Skills</h2>
    <ul class="skills">
        <li class="skill-entry">{{skillName}}</li>
    </ul>
</div>
```
Note in the above example, the `section` class is not relevant. Take note of `skill-entry`, which defines the parent element of a macroized element. This is important so the scanner knows where to replace the macros and duplicate the elements. This allows template authors to customize their templates without worrying about the inner workings of the application.

Also, note that the `skills` class is not relevant. This is used to style the list of skills.

### Example Template Output
Assuming 3 skills are provided, named `HTML`, `CSS`, and `JavaScript`, the application would process them into the following output:
```html
<div class="section" id="skills-section">
    <h2>Skills</h2>
    <ul class="skills">
        <li class="skill-entry">HTML</li>
        <li class="skill-entry">CSS</li>
        <li class="skill-entry">JavaScript</li>
    </ul>
</div>
```