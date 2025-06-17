# Template Reference Guide

CareerCanvas templates are plain HTML with **macros** marking where user data should be injected. There are two macro categories:

1. **Static Macros** – replaced once with a single value.  
2. **Dynamic Macros** – repeated for each item in a list (e.g., multiple jobs, schools, skills).

Throughout this document:

- `{{macroName}}` denotes a macro.  
- Elements with special `id` attributes guide the engine to duplicate or remove content.  

---

## Table of Contents

<!-- TOC -->
- [1. Macros Overview](#1-macros-overview)  
  - [1.1. Static vs. Dynamic](#11-static-vs-dynamic)  
  - [1.2. ‘Recommended’ vs. Required](#12-recommended-vs-required)  
- [2. Macro List](#2-macro-list)  
  - [2.1. Global Macros](#21-global-macros)  
  - [2.2. Resume-Specific](#22-resume-specific)  
  - [2.3. Cover-Letter-Specific](#23-cover-letter-specific)  
- [3. Static Macro IDs](#3-static-macro-ids)  
- [4. Dynamic Macro Implementation](#4-dynamic-macro-implementation)  
  - [4.1. Section IDs](#41-section-ids)  
  - [4.2. Entry IDs](#42-entry-ids)  
- [5. Examples](#5-examples)  
  - [5.1. Education](#51-education)  
  - [5.2. Work Experience](#52-work-experience)  
  - [5.3. Certifications](#53-certifications)  
  - [5.4. Skills](#54-skills)
- [6. Misc Template Requirements](#6-misc-template-requirements)
<!-- /TOC -->

---

## 1. Macros Overview

### 1.1. Static vs. Dynamic

- **Static Macros**  
  - Format: `{{macroName}}`  
  - Replaced exactly once with a single value (e.g., full name).  
  - Can appear anywhere in the document.

- **Dynamic Macros**  
  - Also `{{macroName}}`, but live inside a repeatable container (e.g., `<li>`).  
  - The parent element (or ancestor) must have a designated ID so the engine knows to duplicate it per data item.

### 1.2. ‘Recommended’ vs. Required

- **Required** macros/IDs must be present for the template to render correctly.  
- **Recommended** macros (formerly “required”) are _strongly suggested_ for a good-looking template; missing ones won’t break loading but may leave key sections blank.

---

## 2. Macro List

### 2.1. Global Macros

| Macro                 | Description                       | Required | Dynamic | Placeholder |
|:----------------------|:----------------------------------|:--------:|:-------:|:-----------:|
| `{{fullName}}`        | User’s full name                  |   Yes    |   No    | No          |
| `{{homeAddress}}`     | Legal residence                   |   No     |   No    | No          |
| `{{emailAddress}}`    | Email                             |   No     |   No    | No          |
| `{{phoneNumber}}`     | Phone                             |   No     |   No    | No          |
| `{{linkedIn}}`        | LinkedIn URL                      |   No     |   No    | No          |
| `{{currentDate}}`     | Today’s date (e.g. “May 15, 2025”)|   No     |   No    | No          |

### 2.2. Resume-Specific Macros

| Macro                     | Description                           | Req. | Dyn. | Placeholder |
|:--------------------------|:--------------------------------------|:----:|:----:|:-----------:|
| `{{resumeSummary}}`       | Professional summary                  | Rec. | No   | Yes         |
| **Work History**           |                                       |      |      |             |
| `{{jobTitle}}`             | Job title                             | Yes  | Yes  | No          |
| `{{jobCompanyName}}`       | Employer                              | Yes  | Yes  | No          |
| `{{jobStartDate}}`         | “MMM YYYY” start                      | No   | Yes  | No          |
| `{{jobEndDate}}`           | “MMM YYYY” end                        | No   | Yes  | No          |
| `{{jobDescription}}`       | Role description                      | No   | Yes  | No          |
| **Education**               |                                       |      |      |             |
| `{{degreeType}}`           | Degree                                | Yes  | Yes  | No          |
| `{{schoolName}}`           | Institution                           | Yes  | Yes  | No          |
| `{{schoolStartDate}}`      | “MMM YYYY” start                      | No   | Yes  | No          |
| `{{schoolEndDate}}`        | “MMM YYYY” end                        | No   | Yes  | No          |
| **Certifications**          |                                       |      |      |             |
| `{{certificateName}}`      | Certification                         | Yes  | Yes  | No          |
| `{{certificateIssuingOrganization}}` | Issuer                  | Yes  | Yes  | No          |
| `{{certificateDate}}`      | Date issued (“MMM YYYY”)             | No   | Yes  | No          |
| **Skills**                  |                                       |      |      |             |
| `{{skillName}}`            | Individual skill                     | No   | Yes  | Yes         |

### 2.3. Cover-Letter-Specific

| Macro                           | Description                 | Req. | Dyn. | Placeholder |
|:--------------------------------|:----------------------------|:----:|:----:|:-----------:|
| `{{coverLetterCompanyName}}`    | Recipient company           | Yes  | No   | No          |
| `{{appliedJobTitle}}`           | Position applied for        | Yes  | No   | No          |
| `{{coverLetterContent}}`        | Main letter body            | Yes  | No   | No          |
| `{{coverLetterRecipientPrefix}}`| e.g. “Mr.” / “Ms.”          | No   | No   | No          |
| `{{coverLetterRecipientFirstName}}`, `LastName`, `Title`, etc. | Optional salutations | No | No | No |

---

## 3. Static Macro IDs

Each static macro must have its parent element tagged with an `id` so that if the user omits that field, the entire element can be removed:

| Macro                 | ID                   |
|:----------------------|:---------------------|
| `{{fullName}}`        | `name`               |
| `{{homeAddress}}`     | `address`            |
| `{{emailAddress}}`    | `email`              |
| `{{phoneNumber}}`     | `phonenumber`        |
| `{{linkedIn}}`        | `linkedin`           |
| `{{resumeSummary}}`   | `professional-summary` |

---

## 4. Dynamic Macro Implementation

Wrap your repeatable blocks in elements with **section** and **entry** IDs. The engine:

1. Duplicates the entry element for each data item.  
2. Removes the whole section if the data array is empty.

### 4.1. Section IDs

| Section                 | ID                   | Required |
|:------------------------|:---------------------|:--------:|
| Summary                 | `summary-section`    | Yes      |
| Education               | `education-section`  | Yes      |
| Work Experience         | `experience-section` | Yes      |
| Certifications          | `certificate-section`| Yes      |
| Skills                  | `skills-section`     | No       |
| Contact Info (CV only)  | `contact-section`    | No       |

### 4.2. Entry IDs

| Entry Type        | ID               | Required |
|:------------------|:-----------------|:--------:|
| Education item    | `education-entry`| Yes      |
| Job item          | `job-entry`      | Yes      |
| Certificate item  | `certificate-entry`| Yes    |
| Skill item        | `skill-entry`    | Yes      |

---

## 5. Examples

### 5.1. Education

```html
<div class="section" id="education-section">
  <h2>Education</h2>
  <ul class="education">
    <li class="education-entry">
      <h3>{{degreeType}} – {{schoolName}}</h3>
      <p>{{schoolStartDate}} – {{schoolEndDate}}</p>
    </li>
  </ul>
</div>
```

### 5.2. Work Experience

```html
<div class="section" id="experience-section">
  <h2>Experience</h2>
  <ul class="experience">
    <li class="job-entry">
      <h3>{{jobTitle}} @ {{jobCompanyName}}</h3>
      <p>{{jobStartDate}} – {{jobEndDate}}</p>
      <p>{{jobDescription}}</p>
    </li>
  </ul>
</div>
```

### 5.3. Certifications

```html
<div class="section" id="certificate-section">
  <h2>Certifications</h2>
  <ul class="certificates">
    <li class="certificate-entry">
      <h3>{{certificateName}}</h3>
      <p>{{certificateIssuingOrganization}} ({{certificateDate}})</p>
    </li>
  </ul>
</div>
```

### 5.4. Skills

```html
<div class="section" id="skills-section">
  <h2>Skills</h2>
  <ul class="skills">
    <li class="skill-entry">{{skillName}}</li>
  </ul>
</div>
```

## 6. Misc Template Requirements
- **HTML5**: All templates must be valid HTML5.
- **CSS Classes**: Use classes for styling, not IDs. IDs are reserved for macros and section/entry IDs.
- **No Inline Styles**: Avoid inline styles; use CSS classes instead.
