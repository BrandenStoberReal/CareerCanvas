# Table of Contents
<!--TOC-->
- [Template Options](#template-options)
  - [Macros](#macros)
  - ['Required' Macro Foreword](#required-macro-foreword)
  - [List of Macros](#list-of-macros)
  - [Resume Specific Macros](#resume-specific-macros)
  - [Cover Letter Specific Macros](#cover-letter-specific-macros)
  - [Static Macros](#static-macros)
    - [Static Macro Implementation](#static-macro-implementation)
    - [Static Macro IDs](#static-macro-ids)
  - [Dynamic Macros](#dynamic-macros)
    - [Dynamic Macro Implementation](#dynamic-macro-implementation)
    - [Dynamic Macro IDs](#dynamic-macro-ids)
      - [Section IDs](#section-ids)
      - [Entry IDs](#entry-ids)
  - [Examples](#examples)
    - [Education Container - Resume](#education-container-resume)
    - [Work Container - Resume](#work-container-resume)
    - [Certification Container - Resume](#certification-container-resume)
    - [Skills Container - Resume](#skills-container-resume)
    - [Example Template Output - Resume](#example-template-output-resume)
<!--/TOC-->

# Template Options
CareerCanvas allows you to create custom templates out of HTML. To do this, some information needs to be marked so the application knows how to process it.

## Macros
Macros are used to mark the information that needs to be replaced. They are defined in the following format:
```html
{{macro_name}}
```
Where `macro_name` is the name of the macro. The macro names should be `unique`. For macros that are used to replace list information, see the [dynamic macros](#dynamic-macro-implementation) section below.

There are two types of macro types: `static` and `dynamic`.
A `static macro` is a macro that will be replaced with a `static value`. For example, the `{{fullName}}` macro will be replaced with the full name of the template's owner. `These macros can be defined anywhere in the document without issue`.
A `dynamic macro` is a macro that will be replaced with a `dynamic value`. For example, the `{{jobTitle}}` macro's parent element will be duplicated for every job in the users work history. `The parent elements of these macros require special element IDs`. Read the section on [dynamic macros](#dynamic-macro-implementation) further in this document for details.

Static macros can be defined anywhere in the document. For example, the following is a valid macro:
```html
<p>{{fullName}}</p>
```
This will be replaced with the full name of the template's owner.

Both macro types can also be defined anywhere in the HTML element. For example, the following is a valid, albeit useless, macro:
```html
<div class="template">
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
Some macros are listed as `required` in the table below. Despite the name, these macros are not inherently forced to be in the template; however, macros marked with the `required` entry are strongly recommended to include, as they typically compose the foundation of the document or are otherwise integral information. The application `will still load your template` if a required macro remains undefined, however, your template will likely look very bad.


## List of Macros
| Macro Name | Description | Required? | Dynamic? | Placeholder Available? |
| :---: | :---: | :---: | :---: | :---: |
| `{{fullName}}` | The full name of the template's owner. | Yes | No | No |
| `{{homeAddress}}` | The template owner's legal residence. | No | No | No |
| `{{emailAddress}}` | The template owner's email address. | No | No | No |
| `{{phoneNumber}}` | The template owner's phone number. | No | No | No |
| `{{linkedIn}}` | The template owner's LinkedIn profile. | No | No | No |
| `{{currentDate}}` | A placeholder for the current date (MMM DD, YYYY). | No | No | No |

## Resume Specific Macros
| Macro Name | Description | Required? | Dynamic? | Placeholder Available? |
| :---: | :---: | :---: | :---: | :---: |
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

## Cover Letter Specific Macros
| Macro Name | Description | Required? | Dynamic? | Placeholder Available? |
| :---: | :---: | :---: | :---: | :---: |
| `{{coverLetterCompanyName}}` | A placeholder for the name of the company the cover letter is addressed to. | Yes | No | No |
| `{{coverLetterCompanyAddress}}` | A placeholder for the address of the company the cover letter is addressed to. | No | No | No |
| `{{coverLetterCompanyCity}}` | A placeholder for the city of the company the cover letter is addressed to. | No | No | No |
| `{{coverLetterCompanyState}}` | A placeholder for the state of the company the cover letter is addressed to. | No | No | No |
| `{{coverLetterCompanyZip}}` | A placeholder for the zip code of the company the cover letter is addressed to. | No | No | No |
| `{{coverLetterCompanyPhone}}` | A placeholder for the phone number of the company the cover letter is addressed to. | No | No | No |
| `{{coverLetterCompanyEmail}}` | A placeholder for the email address of the company the cover letter is addressed to. | No | No | No |
| `{{coverLetterCompanyWebsite}}` | A placeholder for the website of the company the cover letter is addressed to. | No | No | No |
| `{{coverLetterContent}}` | A placeholder for the content of the cover letter. | Yes | No | No |
| `{{appliedJobTitle}}` | A placeholder for the job title the cover letter is addressing. | Yes | No | No |
| `{{coverLetterRecipientFirstName}}` | A placeholder for the first name of the recipient of the cover letter. | No | No | No |
| `{{coverLetterRecipientLastName}}` | A placeholder for the last name of the recipient of the cover letter. | No | No | No |
| `{{coverLetterRecipientTitle}}` | A placeholder for the title of the recipient of the cover letter. | No | No | No |
| `{{coverLetterRecipientPrefix}}` | A placeholder for the prefix of the recipient of the cover letter. | No | No | No |

## Static Macros
**This section only applies to resumes! Static macros are handled uniquely in CVs!**

### Static Macro Implementation
Static macros are required to be assigned a unique ID. This is used to delete the macro's parent element if the user does not provide relevant data. Each static macro has its own ID, which is used to identify the parent element of the macro and delete/modify it if needed.

### Static Macro IDs
| Macro Name | ID |
| :---: | :---: |
| `{{fullName}}` | `name` |
| `{{homeAddress}}` | `address` |
| `{{emailAddress}}` | `email` |
| `{{phoneNumber}}` | `phonenumber` |
| `{{linkedIn}}` | `linkedin` |
| `{{resumeSummary}}` | `professional-summary` |

## Dynamic Macros
**This section only applies to resumes! Dynamic macros do not exist in CVs!**

### Dynamic Macro Implementation
Dynamic macros are used to create a list of items that are repeated for each item in the list. For example, the `{{jobTitle}}` macro will be replaced with the job title of each job in the user's work history.

For these macros to function properly, a template developer needs to explicitly mark the parent element of the macro with a [unique ID](#dynamic-macro-ids).

There are currently four categories for dynamic macros: `education`, `work`, `certification`, and `skills`. Each category has its own set of macros that are used to identify the parent element of the macro.

Dynamic macros are always replaced `recursively` as long as the criteria for the parent element is met. This means that if a dynamic macro's element is nested inside another dynamic macro's element, both macros would be filled regardless of the hierarchy.

### Dynamic Macro IDs
Some hardcoded HTML element IDs are required to be present in the template. These IDs are used to identify the parent element of the macro and are used to duplicate the element for each item in the list. The IDs are also used to delete the parent element if the user does not provide relevant data, and other assorted things.

Please note that any ID marked as 'required' `must be present` in the template. If the ID is not present, the application will not correctly replace the macros and the template will not be valid. The application will still load the template, but it will not be able to replace the macros.

#### Section IDs
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

#### Entry IDs
These IDs are used to replace the macros located as a descendant of the element with the ID.

| Entry Name | ID | Required? |
| :---: | :---: | :---: |
| Education Entry | `education-entry` | Yes |
| Work Entry | `job-entry` | Yes |
| Certification Entry | `certificate-entry` | Yes |
| Skills Entry | `skill-entry` | Yes |

## Examples
### Education Container - Resume
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

Important fields:
- `education-entry` - This is the parent element of the macroized elements. This is important so the scanner knows where to replace the macros and duplicate the elements.
- `education-section` - This is the ID of the entry's parent section. This is used to delete the section if the user does not provide any data to fill.

### Work Container - Resume
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

Important fields:
- `job-entry` - This is the parent element of the macroized elements. This is important so the scanner knows where to replace the macros and duplicate the elements.
- `experience-section` - This is the ID of the entry's parent section. This is used to delete the section if the user does not provide any data to fill.

### Certification Container - Resume
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

Important fields:
- `certificate-entry` - This is the parent element of the macroized elements. This is important so the scanner knows where to replace the macros and duplicate the elements.
- `certificate-section` - This is the ID of the entry's parent section. This is used to delete the section if the user does not provide any data to fill.

### Skills Container - Resume
An example is provided below from one of the default templates:
```html
<div class="section" id="skills-section">
    <h2>Skills</h2>
    <ul class="skills">
        <li class="skill-entry">{{skillName}}</li>
    </ul>
</div>
```

Important fields:
- `skill-entry` - This is the parent element of the macroized elements. This is important so the scanner knows where to replace the macros and duplicate the elements.
- `skills-section` - This is the ID of the entry's parent section. This is used to delete the section if the user does not provide any data to fill.

### Example Template Output - Resume
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

This would be the final HTML of the skills section rendered by the application given the previous input data.