<!-- BEGIN MICROSOFT SECURITY.MD V0.0.5 BLOCK -->

## Security

Microsoft takes the security of our software products and services seriously, which includes all source code repositories managed through our GitHub organizations, which include [Microsoft](https://github.com/Microsoft), [Azure](https://github.com/Azure), [DotNet](https://github.com/dotnet), [AspNet](https://github.com/aspnet), [Xamarin](https://github.com/xamarin), and [our GitHub organizations](https://opensource.microsoft.com/).

If you believe you have found a security vulnerability in any Microsoft-owned repository that meets [Microsoft's definition of a security vulnerability](https://docs.microsoft.com/en-us/previous-versions/tn-archive/cc751383(v=technet.10)), please report it to us as described below.

## Reporting Security Issues

**Please do not report security vulnerabilities through public GitHub issues.**

Instead, please report them to the Microsoft Security Response Center (MSRC) at [https://msrc.microsoft.com/create-report](https://msrc.microsoft.com/create-report).

If you prefer to submit without logging in, send email to [secure@microsoft.com](mailto:secure@microsoft.com).  If possible, encrypt your message with our PGP key; please download it from the [Microsoft Security Response Center PGP Key page](https://www.microsoft.com/en-us/msrc/pgp-key-msrc).

You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Additional information can be found at [microsoft.com/msrc](https://www.microsoft.com/msrc). 

Please include the requested information listed below (as much as you can provide) to help us better understand the nature and scope of the possible issue:

  * Type of issue (e.g. buffer overflow, SQL injection, cross-site scripting, etc.)
  * Full paths of source file(s) related to the manifestation of the issue
  * The location of the affected source code (tag/branch/commit or direct URL)
  * Any special configuration required to reproduce the issue
  * Step-by-step instructions to reproduce the issue
  * Proof-of-concept or exploit code (if possible)
  * Impact of the issue, including how an attacker might exploit the issue

This information will help us triage your report more quickly.

If you are reporting for a bug bounty, more complete reports can contribute to a higher bounty award. Please visit our [Microsoft Bug Bounty Program](https://microsoft.com/msrc/bounty) page for more details about our active programs.

## Preferred Languages

We prefer all communications to be in English.

## Policy

Microsoft follows the principle of [Coordinated Vulnerability Disclosure](https://www.microsoft.com/en-us/msrc/cvd).

<!-- END MICROSOFT SECURITY.MD BLOCK -->

## Secret Detection

This repo is configured to detect secrets at multiple levels

1. At **development** time via git pre-commit hooks
1. At **review time** via GitHub actions for all pull requests

### Prerequisites

The following components are required to be pre-installed when developing locally.

1. [Python version >= 3.8.0](https://www.python.org/downloads/)

> You can optionally open this app in a [VS Code remote container](https://code.visualstudio.com/docs/remote/containers) OR [GitHub Codespace](https://github.com/features/codespaces).

### Setup

The baseline security supports 2 modes of development. Developing Locally and using Dev Containers or Codespaces.

#### Developing Locally

Git pre-commit hooks require setup before they can start working as designed.
To streamline this process run the following:

```bash
. ./scripts/detect-secrets/init.sh
```

> Don't forget the *space* between the dots above

The detect-secrets `init.sh` script performs the following:

1. Creates and activates a Python virtual environment
1. Installs python package dependencies via pip
   * [pre-commit](https://github.com/pre-commit/pre-commit) - For git pre-commit hook framework
   * [detect-secrets](https://github.com/Yelp/detect-secrets) - Package developed by Yelp! for secret detection
1. Configures pre-commits hooks from the `.pre-commit-config.yaml` config file.
1. Runs all hooks to create an initial baseline check

#### Using Dev Container / Codespace

Good news! The dev container is automatically configured and runs the detect-secrets `init.sh` script as part of the dev container `postCreateCommand`. You repo will automatically be protected and secure.

### Getting Started

Review the [getting started docs](https://github.com/wbreza/pre-commit-hooks/blob/main/detect-secrets/README.md) for full details on scanning, auditing and reporting against secrets within your repo.