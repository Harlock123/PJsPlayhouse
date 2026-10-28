# AGENTS.md

Notes for anyone, human or AI agent, changing this code. There is no README; this file says what is here and how
to build it.

## What this is

An early prototype of a member-facing health-plan app ("PJs Playground" on its main page), with a stub web
service beside it:

- `PJsPlayhouse/`: a Xamarin.Forms 3.1 app, a shared `netstandard2.0` library plus Android, iOS and UWP heads.
- `MobileServiceLayer/`: an ASP.NET Core 2.1 Web API project.

The two are not connected yet. The app shows hard-coded sample data, and the service's controllers are the
scaffolded templates that return placeholder values.

Building the app needs Visual Studio with the Xamarin workload (and a Mac for the iOS head). The service targets
`netcoreapp2.1`, which is long out of support; current SDKs may need its targeting pack or a retarget.

## Commands

- Open `PJsPlayhouse.sln` in Visual Studio; it holds all five projects.
- `dotnet run --project MobileServiceLayer` starts the service on https://localhost:5001 (see
  `Properties/launchSettings.json`); `api/values` is its launch URL.

There are no tests yet, and no CI workflow.

## Layout

- `PJsPlayhouse/PJsPlayhouse/`: the shared app.
  - `App.xaml.cs` wraps `MainPage` in a `NavigationPage`.
  - `MainPage` has five buttons. My Team and My Messages open real pages; Assessments, Services and Authorizations
    open `UnderConstructionPage`.
  - `MyTeamPage` and `MyMessages` fill their lists in code with `Controls/TeamMember` and `Controls/MemberMessage`
    cards.
- `PJsPlayhouse/PJsPlayhouse.Android`, `.iOS`, `.UWP`: platform heads with launch code and icons only.
- `MobileServiceLayer/Controllers/`: one template controller per area (assessments, auths, care gaps, claims,
  medications, messages, plans, providers, schedule). `InterfaceClasses.cs` holds draft `CareGap`, `Auth` and
  `Claim` models.

## Making a change

- The sample lists live in the page constructors. Wiring a page to the service means replacing them, and adding
  matching models on both sides.
- Navigate with `Navigation.PushAsync`, as the existing pages do.
