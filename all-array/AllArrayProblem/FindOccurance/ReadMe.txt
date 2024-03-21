Console.ReadLine().Split(" ").Select(int.Parse).ToArray();



3 Sum
-------------------------------------------------

private static List<Integer[]> findThreeSum(int[] nums, int target) {
    List<Integer[]> result = new ArrayList<>();
    for (int i = 0; i < nums.length; i++) {
      int currentTarget = target - nums[i];
      Set<Integer> existingNums = new HashSet<>();
      for (int j = i + 1; j < nums.length; j++) {
        if (existingNums.contains(currentTarget - nums[j])) {
          result.add(new Integer[] { nums[i], nums[j], currentTarget - nums[j] });
        } else {
          existingNums.add(nums[j]);
        }
      }
    }
    return result;
  }


  Palindrome Number
------------------------------------

    while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }

Linq:
--------------------------------

            IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "John",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ron" , Age = 20} ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
                };

            var result = from row in studentList
                         group row by row.StudentName into rows
                         select new
                         {
                             StudentName = rows.Key,
                             Average = rows.Average(s => s.Age)
                         };



SELECT 
  t1.firstname As memfname, 
  t1.surname As memsname, 
  t2.firstname As recfname, 
  t2.surname As recsname
FROM cd.members t1
LEFT JOIN cd.members t2 ON t1.recommendedby = t2.memid
ORDER BY t1.surname,t1.firstname


SELECT
    e.first_name || ' ' || e.last_name employee,
    m .first_name || ' ' || m .last_name manager
FROM
    employee e
LEFT JOIN employee m ON m .employee_id = e.manager_id
ORDER BY manager;



   using (var httpClient = this.httpClientProvider.GetHttpClient())
                {
                    string origin = this.configuration.GetValue<string>(AdminAppConstants.OriginKey);
                    string identityUrl = this.configuration.GetValue<string>(AdminAppConstants.IdentityBaseUrlKey);

                    httpClient.DefaultRequestHeaders.Add("Origin", origin);

                    var content = new StringContent(postData, Encoding.UTF8, "application/json");
                    var tokenResponse = await httpClient.PostAsync(identityUrl + "token", content).ConfigureAwait(false);
                    if (tokenResponse.IsSuccessStatusCode)
                    {
                        var tokenResult = await tokenResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

                        Token tokenObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(tokenResult);

                        return tokenObj;
                    }
                    else
                    {
                        this.logger.LogInformation("TokenResponse :: " + tokenResponse.StatusCode);
                        this.logger.LogInformation("TokenResponse :: " + tokenResponse.RequestMessage);
                        return null;
                    }
                }


behind master branch.