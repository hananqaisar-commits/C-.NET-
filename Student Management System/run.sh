#!/bin/bash
# To find the path and run the programme
case "$(uname -s)" in
    Linux*|Darwin*) SEARCH_ROOT="$HOME" ;;
    MINGW*|MSYS*|CYGWIN*) SEARCH_ROOT="/c/Users" ;;
    *) echo "Unknown OS"; exit 1 ;;
esac
PROJECT_PATH=$(find "$SEARCH_ROOT" -type d -iname "Student Management System"  2>/dev/null | head -n 1)
if [ -z "$PROJECT_PATH" ]; then
    echo "Project folder not found under $SEARCH_ROOT"
    exit 1
fi
cd "$PROJECT_PATH" || exit 1
dotnet run