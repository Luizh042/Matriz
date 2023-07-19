#!/bin/bash
proj_name="MTZ"
proj_tests="${proj_name}.Tests"
cd "$proj_name"
dotnet run
cd ..