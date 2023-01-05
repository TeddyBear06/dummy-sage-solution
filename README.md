# POC

## Open dev cmd VS

"Tools" => "Command line" > "Tools for devs"

### Check manifest

```
ildasm
```

### Deep debug

```
SxsTrace Trace -logfile:SxsTrace.etl
```

Then press Return and :

```
sxstrace Parse -logfile:SxSTrace.etl -outfile:SxSTrace.txt
SxSTrace.txt
```