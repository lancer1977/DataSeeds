def csv2json:
  split("\n")                              # Split input into lines
  | .[0] as $headers                       # Save the first line as headers
  | [ .[1:][]                                # Start from the second line
      | split(",")                         # Split each line into an array
      | reduce range(0; length) as $i     # For each index
          ({}; .[$headers[$i]] = .[$i])   # Create an object using the headers
  ] ;

csv2json
