export interface PaginatedData {
    currentPage: number,
    from: number,
    pageSize: number,
    to: number,
    totalCount: number,
    totalPages: number,
    hasPreviousPage: boolean,
    hasNextPage: boolean, 
}

export interface PaginatedListItems<T> extends PaginatedData {
    items: T[]
}

export interface PaginatedList<T> extends PaginatedListItems<T> {}