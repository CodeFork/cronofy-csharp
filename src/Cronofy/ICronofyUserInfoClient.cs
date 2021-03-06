﻿namespace Cronofy
{
    using System;

    /// <summary>
    /// Interface for a Cronofy client base that manages the
    /// access token and any shared client methods.
    /// </summary>
    public interface ICronofyUserInfoClient
    {
        /// <summary>
        /// Gets the user info belonging to the account.
        /// </summary>
        /// <returns>The account's user info.</returns>
        /// <exception cref="CronofyException">
        /// Thrown if an error is encountered whilst making the request.
        /// </exception>
        UserInfo GetUserInfo();
    }
}
